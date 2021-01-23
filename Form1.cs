using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Base_C_Lesson_7
{
    public partial class Form1 : Form
    {

        public int gameNumber = 0;
        public int gameMinSteps = 0;


        // Структура для истории
        struct History
        {
            public int number, cntPushPlus, cntPushMulti, gameNumber, cntPushGame, gameMinSteps;
        }

        // История
        Stack<History> history = new Stack<History>();

        public Form1()
        {
            InitializeComponent();
            //
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "1";
            this.Text = "Удвоитель";

            // Записываем историю
            SetHistory();
        }

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            // Записываем историю
            SetHistory();

            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            // Считаем
            var regex = new Regex("[^0-9]");
            string text = regex.Replace(lblCntPlus.Text, "");
            lblCntPlus.Text = "[нажатий: " + (int.Parse(text) + 1).ToString() + "]";

            // Считаем для игры
            UpdateGameCounter();
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            // Записываем историю
            SetHistory();

            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            // Считаем
            var regex = new Regex("[^0-9]");
            string text = regex.Replace(lblCntMulti.Text, "");
            lblCntMulti.Text = "[нажатий: " + (int.Parse(text) + 1).ToString() + "]";

            // Считаем для игры
            UpdateGameCounter();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCntPlus.Text = "[нажатий: 0]";
            lblCntMulti.Text = "[нажатий: 0]";
        }

        private void btnPlayGame_Click(object sender, EventArgs e)
        {
            // Записываем историю
            SetHistory();

            if (this.gameNumber>0) GameFlash();
            GameStart();
        }


        private void SetHistory()
        {
            var regex = new Regex("[^0-9]");
            History h = new History();
            h.number = int.Parse(regex.Replace(lblNumber.Text, ""));
            h.cntPushPlus = int.Parse(regex.Replace(lblCntPlus.Text, "")); 
            h.cntPushMulti = int.Parse(regex.Replace(lblCntMulti.Text, ""));
            h.gameNumber = int.Parse(regex.Replace(lblGameNumber.Text, ""));
            h.cntPushGame = int.Parse(regex.Replace(lblGameUpush.Text, ""));
            h.gameMinSteps = this.gameMinSteps;
            this.history.Push(h);
        }

        private void Undo()
        {
            if (this.history.Count > 0)
            {
                var h = this.history.Pop();
                lblNumber.Text = h.number.ToString();
                lblCntPlus.Text = "[нажатий: " + h.cntPushPlus.ToString() + "]";
                lblCntMulti.Text = "[нажатий: " + h.cntPushMulti.ToString() + "]";
                lblGameNumber.Text = "Получить число: " + h.gameNumber.ToString();
                lblGameUpush.Text = "[нажатий: " + h.cntPushGame.ToString() + "]";
                this.gameNumber = h.gameNumber;
                this.gameMinSteps = h.gameMinSteps;
            }
        }


        private void GameStart()
        {
            var rnd = new Random();
            this.gameNumber = rnd.Next(10, 20);
            lblGameNumber.Text = "Получить число: " + this.gameNumber.ToString();
            MessageBox.Show("Получите число " + this.gameNumber + " за минимальное количество ходов!");
            
            this.gameMinSteps = GetMinSteps();
        }


        private void UpdateGameCounter()
        {
            if (this.gameNumber > 0)
            {
                var regex = new Regex("[^0-9]");
                string text = regex.Replace(lblGameUpush.Text, "");
                lblGameUpush.Text = "[нажатий: " + (int.Parse(text) + 1).ToString()+"]";
                GameCheck();
            }
        }

        private int GetGameCounter()
        {
            var regex = new Regex("[^0-9]");
            return int.Parse(regex.Replace(lblGameUpush.Text, ""));
        }


        private int GetMinSteps()
        {
            int steps = 0;
            int nowNumber = int.Parse(lblNumber.Text);
            while(true)
            {
                if (nowNumber * 2 > this.gameNumber) break;
                nowNumber *= 2;
                steps++;
            }
            steps += this.gameNumber - nowNumber;
            return steps;
        }



        private bool GameCheck()
        {
            bool result = false;
            if (this.gameNumber > 0)
            {
                // Текущее число
                int nowNumber = int.Parse(lblNumber.Text);
                if(nowNumber > this.gameNumber)
                {
                    MessageBox.Show("Вы проиграли. Число "+ nowNumber + " больше необходимого числа.");
                    GameFlash();
                }
                else if(nowNumber == this.gameNumber)
                {
                    // Текущий счетчик
                    int gameSteps = GetGameCounter();

                    // Проверям соответствие минимальным шагам
                    if (gameSteps == this.gameMinSteps) 
                        MessageBox.Show("Вы выиграли! Число "+ this.gameNumber+ " достигнуто за минимальное количество шагов (" + this.gameMinSteps + ").");
                    else
                        MessageBox.Show("Вы проиграли! Число " + this.gameNumber + " НЕ достигнуто за минимальное количество шагов ("+ this.gameMinSteps + ").");

                    GameFlash();
                }
            }
            return result;
        }


        private void GameFlash()
        {
            this.gameNumber = 0;
            this.gameMinSteps = 0;
            lblGameUpush.Text = "[нажатий: 0]";
            lblGameNumber.Text = "Получить число: 0";
            lblNumber.Text = "1";
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }
    }
}
