namespace Tic_Tac_Toe_Game
{
    partial class Form1
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
            this.leGame = new System.Windows.Forms.Label();
            this.leTurn = new System.Windows.Forms.Label();
            this.lePlyer_Turn = new System.Windows.Forms.Label();
            this.leWinnr = new System.Windows.Forms.Label();
            this.leHow_Winner = new System.Windows.Forms.Label();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // leGame
            // 
            this.leGame.AutoSize = true;
            this.leGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.leGame.Font = new System.Drawing.Font("NSimSun", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leGame.ForeColor = System.Drawing.SystemColors.Control;
            this.leGame.Location = new System.Drawing.Point(338, 41);
            this.leGame.Name = "leGame";
            this.leGame.Size = new System.Drawing.Size(420, 48);
            this.leGame.TabIndex = 0;
            this.leGame.Text = "Tic-Tac-Toe Game";
            // 
            // leTurn
            // 
            this.leTurn.AutoSize = true;
            this.leTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leTurn.ForeColor = System.Drawing.Color.Gold;
            this.leTurn.Location = new System.Drawing.Point(41, 100);
            this.leTurn.Name = "leTurn";
            this.leTurn.Size = new System.Drawing.Size(99, 42);
            this.leTurn.TabIndex = 1;
            this.leTurn.Text = "Turn";
            // 
            // lePlyer_Turn
            // 
            this.lePlyer_Turn.AutoSize = true;
            this.lePlyer_Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lePlyer_Turn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lePlyer_Turn.Location = new System.Drawing.Point(41, 152);
            this.lePlyer_Turn.Name = "lePlyer_Turn";
            this.lePlyer_Turn.Size = new System.Drawing.Size(152, 42);
            this.lePlyer_Turn.TabIndex = 2;
            this.lePlyer_Turn.Text = "Player1";
            // 
            // leWinnr
            // 
            this.leWinnr.AutoSize = true;
            this.leWinnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leWinnr.ForeColor = System.Drawing.Color.Gold;
            this.leWinnr.Location = new System.Drawing.Point(41, 210);
            this.leWinnr.Name = "leWinnr";
            this.leWinnr.Size = new System.Drawing.Size(142, 42);
            this.leWinnr.TabIndex = 3;
            this.leWinnr.Text = "Winner";
            // 
            // leHow_Winner
            // 
            this.leHow_Winner.AutoSize = true;
            this.leHow_Winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leHow_Winner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leHow_Winner.Location = new System.Drawing.Point(41, 266);
            this.leHow_Winner.Name = "leHow_Winner";
            this.leHow_Winner.Size = new System.Drawing.Size(231, 42);
            this.leHow_Winner.TabIndex = 4;
            this.leHow_Winner.Text = "How Winner";
            // 
            // button0
            // 
            this.button0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button0.BackColor = System.Drawing.Color.Black;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button0.Location = new System.Drawing.Point(48, 330);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(194, 39);
            this.button0.TabIndex = 5;
            this.button0.Text = "Restard Game";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button9
            // 
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.BackColor = System.Drawing.Color.Black;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button9.Location = new System.Drawing.Point(626, 348);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 80);
            this.button9.TabIndex = 14;
            this.button9.Tag = "?";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.BackColor = System.Drawing.Color.Black;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button8.Location = new System.Drawing.Point(490, 348);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 80);
            this.button8.TabIndex = 13;
            this.button8.Tag = "?";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button7.Location = new System.Drawing.Point(346, 348);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 80);
            this.button7.TabIndex = 12;
            this.button7.Tag = "?";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button6.Location = new System.Drawing.Point(626, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 80);
            this.button6.TabIndex = 11;
            this.button6.Tag = "?";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button5.Location = new System.Drawing.Point(490, 228);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 80);
            this.button5.TabIndex = 10;
            this.button5.Tag = "?";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button4.Location = new System.Drawing.Point(346, 228);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 80);
            this.button4.TabIndex = 9;
            this.button4.Tag = "?";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button3.Location = new System.Drawing.Point(626, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 80);
            this.button3.TabIndex = 8;
            this.button3.Tag = "?";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button2.Location = new System.Drawing.Point(490, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 80);
            this.button2.TabIndex = 7;
            this.button2.Tag = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Tic_Tac_Toe_Game.Properties.Resources.question_mark_96;
            this.button1.Location = new System.Drawing.Point(346, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 80);
            this.button1.TabIndex = 6;
            this.button1.Tag = "?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.leHow_Winner);
            this.Controls.Add(this.leWinnr);
            this.Controls.Add(this.lePlyer_Turn);
            this.Controls.Add(this.leTurn);
            this.Controls.Add(this.leGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label leGame;
        private System.Windows.Forms.Label leTurn;
        private System.Windows.Forms.Label lePlyer_Turn;
        private System.Windows.Forms.Label leWinnr;
        private System.Windows.Forms.Label leHow_Winner;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

