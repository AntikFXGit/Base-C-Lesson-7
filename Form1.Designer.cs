
namespace Base_C_Lesson_7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblCntPlus = new System.Windows.Forms.Label();
            this.lblCntMulti = new System.Windows.Forms.Label();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGameUpush = new System.Windows.Forms.Label();
            this.lblGameNumber = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(6, 30);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "1";
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(129, 25);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 1;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(129, 63);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(129, 102);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblCntPlus
            // 
            this.lblCntPlus.AutoSize = true;
            this.lblCntPlus.Location = new System.Drawing.Point(211, 30);
            this.lblCntPlus.Name = "lblCntPlus";
            this.lblCntPlus.Size = new System.Drawing.Size(68, 13);
            this.lblCntPlus.TabIndex = 0;
            this.lblCntPlus.Text = "[нажатий: 0]";
            // 
            // lblCntMulti
            // 
            this.lblCntMulti.AutoSize = true;
            this.lblCntMulti.Location = new System.Drawing.Point(211, 68);
            this.lblCntMulti.Name = "lblCntMulti";
            this.lblCntMulti.Size = new System.Drawing.Size(68, 13);
            this.lblCntMulti.TabIndex = 0;
            this.lblCntMulti.Text = "[нажатий: 0]";
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(129, 158);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(75, 23);
            this.btnPlayGame.TabIndex = 2;
            this.btnPlayGame.Text = "Играть!";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 2);
            this.label1.TabIndex = 3;
            // 
            // lblGameUpush
            // 
            this.lblGameUpush.AutoSize = true;
            this.lblGameUpush.Location = new System.Drawing.Point(211, 163);
            this.lblGameUpush.Name = "lblGameUpush";
            this.lblGameUpush.Size = new System.Drawing.Size(68, 13);
            this.lblGameUpush.TabIndex = 4;
            this.lblGameUpush.Text = "[нажатий: 0]";
            // 
            // lblGameNumber
            // 
            this.lblGameNumber.AutoSize = true;
            this.lblGameNumber.Location = new System.Drawing.Point(6, 163);
            this.lblGameNumber.Name = "lblGameNumber";
            this.lblGameNumber.Size = new System.Drawing.Size(98, 13);
            this.lblGameNumber.TabIndex = 0;
            this.lblGameNumber.Text = "Получить число: 0";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(214, 102);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(58, 23);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lblGameUpush);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.lblCntMulti);
            this.Controls.Add(this.lblCntPlus);
            this.Controls.Add(this.lblGameNumber);
            this.Controls.Add(this.lblNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblCntPlus;
        private System.Windows.Forms.Label lblCntMulti;
        private System.Windows.Forms.Button btnPlayGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGameUpush;
        private System.Windows.Forms.Label lblGameNumber;
        private System.Windows.Forms.Button btnUndo;
    }
}

