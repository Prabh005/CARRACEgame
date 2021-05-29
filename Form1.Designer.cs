
namespace RacingGame
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
            this.pnlGameOver = new System.Windows.Forms.Panel();
            this.lblLastPunter = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numUDCarNumber = new System.Windows.Forms.NumericUpDown();
            this.numUDbet = new System.Windows.Forms.NumericUpDown();
            this.txtTes = new System.Windows.Forms.TextBox();
            this.txtLambo = new System.Windows.Forms.TextBox();
            this.txtFera = new System.Windows.Forms.TextBox();
            this.rbAkash = new System.Windows.Forms.RadioButton();
            this.rbRahul = new System.Windows.Forms.RadioButton();
            this.rbPrabh = new System.Windows.Forms.RadioButton();
            this.btnBet = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.pnlGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCarNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDbet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGameOver
            // 
            this.pnlGameOver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlGameOver.Controls.Add(this.lblLastPunter);
            this.pnlGameOver.Controls.Add(this.btnQuit);
            this.pnlGameOver.Controls.Add(this.lblGameOver);
            this.pnlGameOver.Controls.Add(this.btnPlayAgain);
            this.pnlGameOver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlGameOver.Location = new System.Drawing.Point(362, 63);
            this.pnlGameOver.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGameOver.Name = "pnlGameOver";
            this.pnlGameOver.Size = new System.Drawing.Size(340, 279);
            this.pnlGameOver.TabIndex = 39;
            this.pnlGameOver.Visible = false;
            // 
            // lblLastPunter
            // 
            this.lblLastPunter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblLastPunter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPunter.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblLastPunter.Location = new System.Drawing.Point(85, 124);
            this.lblLastPunter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastPunter.Name = "lblLastPunter";
            this.lblLastPunter.Size = new System.Drawing.Size(170, 46);
            this.lblLastPunter.TabIndex = 22;
            this.lblLastPunter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnQuit.Location = new System.Drawing.Point(118, 225);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(108, 28);
            this.btnQuit.TabIndex = 19;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(24, 15);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(291, 69);
            this.lblGameOver.TabIndex = 21;
            this.lblGameOver.Text = "GAME OVER";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnPlayAgain.Location = new System.Drawing.Point(118, 193);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(108, 28);
            this.btnPlayAgain.TabIndex = 18;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(551, 464);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Car Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(588, 408);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Money";
            // 
            // numUDCarNumber
            // 
            this.numUDCarNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDCarNumber.Location = new System.Drawing.Point(648, 460);
            this.numUDCarNumber.Margin = new System.Windows.Forms.Padding(2);
            this.numUDCarNumber.Name = "numUDCarNumber";
            this.numUDCarNumber.Size = new System.Drawing.Size(80, 22);
            this.numUDCarNumber.TabIndex = 36;
            this.numUDCarNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDCarNumber.ValueChanged += new System.EventHandler(this.numUDCarNumber_ValueChanged);
            // 
            // numUDbet
            // 
            this.numUDbet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDbet.Location = new System.Drawing.Point(648, 408);
            this.numUDbet.Margin = new System.Windows.Forms.Padding(2);
            this.numUDbet.Name = "numUDbet";
            this.numUDbet.Size = new System.Drawing.Size(80, 22);
            this.numUDbet.TabIndex = 35;
            this.numUDbet.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // txtTes
            // 
            this.txtTes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTes.Location = new System.Drawing.Point(20, 453);
            this.txtTes.Margin = new System.Windows.Forms.Padding(2);
            this.txtTes.Multiline = true;
            this.txtTes.Name = "txtTes";
            this.txtTes.ReadOnly = true;
            this.txtTes.Size = new System.Drawing.Size(272, 51);
            this.txtTes.TabIndex = 34;
            // 
            // txtLambo
            // 
            this.txtLambo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLambo.Location = new System.Drawing.Point(20, 409);
            this.txtLambo.Margin = new System.Windows.Forms.Padding(2);
            this.txtLambo.Multiline = true;
            this.txtLambo.Name = "txtLambo";
            this.txtLambo.ReadOnly = true;
            this.txtLambo.Size = new System.Drawing.Size(272, 52);
            this.txtLambo.TabIndex = 33;
            this.txtLambo.TextChanged += new System.EventHandler(this.txtLambo_TextChanged);
            // 
            // txtFera
            // 
            this.txtFera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFera.Location = new System.Drawing.Point(20, 365);
            this.txtFera.Margin = new System.Windows.Forms.Padding(2);
            this.txtFera.Multiline = true;
            this.txtFera.Name = "txtFera";
            this.txtFera.ReadOnly = true;
            this.txtFera.Size = new System.Drawing.Size(272, 51);
            this.txtFera.TabIndex = 32;
            // 
            // rbAkash
            // 
            this.rbAkash.AutoSize = true;
            this.rbAkash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAkash.Location = new System.Drawing.Point(770, 460);
            this.rbAkash.Margin = new System.Windows.Forms.Padding(2);
            this.rbAkash.Name = "rbAkash";
            this.rbAkash.Size = new System.Drawing.Size(69, 20);
            this.rbAkash.TabIndex = 31;
            this.rbAkash.TabStop = true;
            this.rbAkash.Text = "Akash";
            this.rbAkash.UseVisualStyleBackColor = true;
            this.rbAkash.CheckedChanged += new System.EventHandler(this.rbAkash_CheckedChanged);
            // 
            // rbRahul
            // 
            this.rbRahul.AutoSize = true;
            this.rbRahul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRahul.Location = new System.Drawing.Point(770, 429);
            this.rbRahul.Margin = new System.Windows.Forms.Padding(2);
            this.rbRahul.Name = "rbRahul";
            this.rbRahul.Size = new System.Drawing.Size(66, 20);
            this.rbRahul.TabIndex = 30;
            this.rbRahul.TabStop = true;
            this.rbRahul.Text = "Rahul";
            this.rbRahul.UseVisualStyleBackColor = true;
            this.rbRahul.CheckedChanged += new System.EventHandler(this.rbRahul_CheckedChanged);
            // 
            // rbPrabh
            // 
            this.rbPrabh.AutoSize = true;
            this.rbPrabh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPrabh.Location = new System.Drawing.Point(770, 396);
            this.rbPrabh.Margin = new System.Windows.Forms.Padding(2);
            this.rbPrabh.Name = "rbPrabh";
            this.rbPrabh.Size = new System.Drawing.Size(67, 20);
            this.rbPrabh.TabIndex = 29;
            this.rbPrabh.TabStop = true;
            this.rbPrabh.Text = "Prabh";
            this.rbPrabh.UseVisualStyleBackColor = true;
            this.rbPrabh.CheckedChanged += new System.EventHandler(this.rbPrabh_CheckedChanged);
            // 
            // btnBet
            // 
            this.btnBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBet.Location = new System.Drawing.Point(864, 427);
            this.btnBet.Margin = new System.Windows.Forms.Padding(2);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(101, 34);
            this.btnBet.TabIndex = 28;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(937, 2);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 28);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(362, 406);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(144, 55);
            this.btnStart.TabIndex = 26;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblWinner
            // 
            this.lblWinner.BackColor = System.Drawing.Color.White;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblWinner.Location = new System.Drawing.Point(312, 169);
            this.lblWinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(293, 147);
            this.lblWinner.TabIndex = 25;
            this.lblWinner.Click += new System.EventHandler(this.lblWinner_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = global::RacingGame.Properties.Resources.red;
            this.pictureBox4.Location = new System.Drawing.Point(1, 285);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(194, 76);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 24;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::RacingGame.Properties.Resources.grey;
            this.pictureBox3.Location = new System.Drawing.Point(1, 185);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::RacingGame.Properties.Resources.yellow;
            this.pictureBox1.Location = new System.Drawing.Point(1, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::RacingGame.Properties.Resources.black;
            this.pictureBox2.Location = new System.Drawing.Point(1, 108);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnback.Location = new System.Drawing.Point(353, 321);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(288, 40);
            this.btnback.TabIndex = 40;
            this.btnback.Text = "Reset Cars Position";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1010, 513);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.pnlGameOver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUDCarNumber);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.numUDbet);
            this.Controls.Add(this.txtTes);
            this.Controls.Add(this.txtLambo);
            this.Controls.Add(this.txtFera);
            this.Controls.Add(this.rbAkash);
            this.Controls.Add(this.rbRahul);
            this.Controls.Add(this.rbPrabh);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlGameOver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDCarNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDbet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameOver;
        private System.Windows.Forms.Label lblLastPunter;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDCarNumber;
        private System.Windows.Forms.NumericUpDown numUDbet;
        private System.Windows.Forms.TextBox txtTes;
        private System.Windows.Forms.TextBox txtLambo;
        private System.Windows.Forms.TextBox txtFera;
        private System.Windows.Forms.RadioButton rbAkash;
        private System.Windows.Forms.RadioButton rbRahul;
        private System.Windows.Forms.RadioButton rbPrabh;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnback;
    }
}

