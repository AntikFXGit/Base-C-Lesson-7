
namespace Base_C_Lesson_7
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopGame = new System.Windows.Forms.Button();
            this.txtUnumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckNumber = new System.Windows.Forms.Button();
            this.lblCntTry = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvlGameStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartGame
            // 
            this.btnStartGame.Location = new System.Drawing.Point(89, 126);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(75, 23);
            this.btnStartGame.TabIndex = 0;
            this.btnStartGame.Text = "Играть!";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 2);
            this.label1.TabIndex = 4;
            // 
            // btnStopGame
            // 
            this.btnStopGame.Location = new System.Drawing.Point(210, 126);
            this.btnStopGame.Name = "btnStopGame";
            this.btnStopGame.Size = new System.Drawing.Size(75, 23);
            this.btnStopGame.TabIndex = 0;
            this.btnStopGame.Text = "Отмена";
            this.btnStopGame.UseVisualStyleBackColor = true;
            this.btnStopGame.Click += new System.EventHandler(this.btnStopGame_Click);
            // 
            // txtUnumber
            // 
            this.txtUnumber.Location = new System.Drawing.Point(99, 74);
            this.txtUnumber.Name = "txtUnumber";
            this.txtUnumber.Size = new System.Drawing.Size(118, 20);
            this.txtUnumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Укажите число";
            // 
            // btnCheckNumber
            // 
            this.btnCheckNumber.Location = new System.Drawing.Point(223, 72);
            this.btnCheckNumber.Name = "btnCheckNumber";
            this.btnCheckNumber.Size = new System.Drawing.Size(75, 23);
            this.btnCheckNumber.TabIndex = 0;
            this.btnCheckNumber.Text = "Проверить";
            this.btnCheckNumber.UseVisualStyleBackColor = true;
            this.btnCheckNumber.Click += new System.EventHandler(this.btnCheckNumber_Click);
            // 
            // lblCntTry
            // 
            this.lblCntTry.AutoSize = true;
            this.lblCntTry.Location = new System.Drawing.Point(304, 77);
            this.lblCntTry.Name = "lblCntTry";
            this.lblCntTry.Size = new System.Drawing.Size(68, 13);
            this.lblCntTry.TabIndex = 7;
            this.lblCntTry.Text = "[попыток: 0]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Статус игры:";
            // 
            // lvlGameStatus
            // 
            this.lvlGameStatus.AutoSize = true;
            this.lvlGameStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lvlGameStatus.Location = new System.Drawing.Point(105, 9);
            this.lvlGameStatus.Name = "lvlGameStatus";
            this.lvlGameStatus.Size = new System.Drawing.Size(35, 13);
            this.lvlGameStatus.TabIndex = 9;
            this.lvlGameStatus.Text = "Откл.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Результат игры:";
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.ForeColor = System.Drawing.Color.Blue;
            this.lblGameResult.Location = new System.Drawing.Point(105, 34);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(0, 13);
            this.lblGameResult.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.lvlGameStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCntTry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckNumber);
            this.Controls.Add(this.btnStopGame);
            this.Controls.Add(this.btnStartGame);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStopGame;
        private System.Windows.Forms.TextBox txtUnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckNumber;
        private System.Windows.Forms.Label lblCntTry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lvlGameStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGameResult;
    }
}