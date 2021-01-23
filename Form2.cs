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
    public partial class Form2 : Form
    {

        int gameNumber = 0;
        
        public Form2()
        {
            InitializeComponent();
            this.Text = "Игра: угадай число.";
        }

        void StartGame()
        {
            Random rnd = new Random();
            this.gameNumber = rnd.Next(1, 100);
            btnStartGame.Enabled = false; // кнопка старт
            lblGameResult.Text = ""; // поле результата
            lvlGameStatus.Text = "Вкл."; // поле статуса
            lvlGameStatus.ForeColor = Color.FromArgb(20, 100, 40);  // поле статуса
            lblCntTry.Text = "[попыток: 0]"; // поле кол-во попыток
            txtUnumber.Text = ""; // поле номера

            //MessageBox.Show("Старт игры, номер: "+ this.gameNumber);
        }

        void StopGame()
        {
            Random rnd = new Random();
            this.gameNumber = 0;
            btnStartGame.Enabled = true;
            lvlGameStatus.Text = "Откл."; // поле статуса
            lvlGameStatus.ForeColor = Color.FromArgb(255, 0, 0);  // поле статуса
        }



        void CheckGame()
        {
            if (this.gameNumber > 0)
            {
                var regex = new Regex("[^0-9]");
                int num = 0, cnt = 0;
                int.TryParse(regex.Replace(txtUnumber.Text, ""), out num);
                int.TryParse(regex.Replace(lblCntTry.Text, ""), out cnt);

                // Кол-во попыток
                lblCntTry.Text = "[попыток: " + (++cnt) + "]";
                if (num>0)
                {
                    if (num == this.gameNumber)
                    {
                        lblGameResult.Text = "Вы победили! Число попыток: " + cnt;
                        StopGame();
                    }
                    else if (num > this.gameNumber)
                    {
                        lblGameResult.Text = "Вы НЕ угадали!\nВы указали число БОЛЬШЕ необходимого.";

                    }
                    else
                    {
                        lblGameResult.Text = "Вы НЕ угадали!\nВы указали число МЕНЬШЕ необходимого.";
                    }
                }
            }
        }

        /* EVENTS...*/
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnStopGame_Click(object sender, EventArgs e)
        {
            StopGame();
        }

        private void btnCheckNumber_Click(object sender, EventArgs e)
        {
            CheckGame();
        }
    }
}
