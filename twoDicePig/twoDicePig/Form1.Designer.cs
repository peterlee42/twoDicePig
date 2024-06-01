namespace twoDicePig
{
    partial class gameForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnPlayP1 = new System.Windows.Forms.Button();
            this.btnHoldP1 = new System.Windows.Forms.Button();
            this.btnPlayP2 = new System.Windows.Forms.Button();
            this.btnHoldP2 = new System.Windows.Forms.Button();
            this.gbPlayer1 = new System.Windows.Forms.GroupBox();
            this.txtGameScoreP1 = new System.Windows.Forms.TextBox();
            this.lblGameScoreP1 = new System.Windows.Forms.Label();
            this.txtTurnScoreP1 = new System.Windows.Forms.TextBox();
            this.lblTurnScoreP1 = new System.Windows.Forms.Label();
            this.txtGameScoreP2 = new System.Windows.Forms.TextBox();
            this.gbPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblGameScoreP2 = new System.Windows.Forms.Label();
            this.txtTurnScoreP2 = new System.Windows.Forms.TextBox();
            this.lblTurnScoreP2 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pbDice1 = new System.Windows.Forms.PictureBox();
            this.pbDice2 = new System.Windows.Forms.PictureBox();
            this.txtTurn = new System.Windows.Forms.TextBox();
            this.lblTurn = new System.Windows.Forms.Label();
            this.gbPlayer1.SuspendLayout();
            this.gbPlayer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(65, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 47);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TWO DICE PIG!!!";
            // 
            // btnPlayP1
            // 
            this.btnPlayP1.Location = new System.Drawing.Point(29, 62);
            this.btnPlayP1.Name = "btnPlayP1";
            this.btnPlayP1.Size = new System.Drawing.Size(179, 57);
            this.btnPlayP1.TabIndex = 4;
            this.btnPlayP1.Text = "PLAY";
            this.btnPlayP1.UseVisualStyleBackColor = true;
            this.btnPlayP1.Click += new System.EventHandler(this.btnPlayP1_Click);
            // 
            // btnHoldP1
            // 
            this.btnHoldP1.Location = new System.Drawing.Point(29, 125);
            this.btnHoldP1.Name = "btnHoldP1";
            this.btnHoldP1.Size = new System.Drawing.Size(179, 55);
            this.btnHoldP1.TabIndex = 5;
            this.btnHoldP1.Text = "HOLD";
            this.btnHoldP1.UseVisualStyleBackColor = true;
            this.btnHoldP1.Click += new System.EventHandler(this.btnHoldP1_Click);
            // 
            // btnPlayP2
            // 
            this.btnPlayP2.Location = new System.Drawing.Point(32, 62);
            this.btnPlayP2.Name = "btnPlayP2";
            this.btnPlayP2.Size = new System.Drawing.Size(179, 57);
            this.btnPlayP2.TabIndex = 10;
            this.btnPlayP2.Text = "PLAY";
            this.btnPlayP2.UseVisualStyleBackColor = true;
            this.btnPlayP2.Click += new System.EventHandler(this.btnPlayP2_Click);
            // 
            // btnHoldP2
            // 
            this.btnHoldP2.Location = new System.Drawing.Point(32, 125);
            this.btnHoldP2.Name = "btnHoldP2";
            this.btnHoldP2.Size = new System.Drawing.Size(179, 55);
            this.btnHoldP2.TabIndex = 11;
            this.btnHoldP2.Text = "HOLD";
            this.btnHoldP2.UseVisualStyleBackColor = true;
            this.btnHoldP2.Click += new System.EventHandler(this.btnHoldP2_Click);
            // 
            // gbPlayer1
            // 
            this.gbPlayer1.Controls.Add(this.txtGameScoreP1);
            this.gbPlayer1.Controls.Add(this.lblGameScoreP1);
            this.gbPlayer1.Controls.Add(this.txtTurnScoreP1);
            this.gbPlayer1.Controls.Add(this.lblTurnScoreP1);
            this.gbPlayer1.Controls.Add(this.btnHoldP1);
            this.gbPlayer1.Controls.Add(this.btnPlayP1);
            this.gbPlayer1.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer1.Location = new System.Drawing.Point(12, 105);
            this.gbPlayer1.Name = "gbPlayer1";
            this.gbPlayer1.Size = new System.Drawing.Size(289, 309);
            this.gbPlayer1.TabIndex = 3;
            this.gbPlayer1.TabStop = false;
            this.gbPlayer1.Text = "Player 1";
            // 
            // txtGameScoreP1
            // 
            this.txtGameScoreP1.Location = new System.Drawing.Point(196, 247);
            this.txtGameScoreP1.Name = "txtGameScoreP1";
            this.txtGameScoreP1.ReadOnly = true;
            this.txtGameScoreP1.Size = new System.Drawing.Size(70, 55);
            this.txtGameScoreP1.TabIndex = 9;
            this.txtGameScoreP1.TabStop = false;
            // 
            // lblGameScoreP1
            // 
            this.lblGameScoreP1.AutoSize = true;
            this.lblGameScoreP1.Location = new System.Drawing.Point(6, 250);
            this.lblGameScoreP1.Name = "lblGameScoreP1";
            this.lblGameScoreP1.Size = new System.Drawing.Size(184, 47);
            this.lblGameScoreP1.TabIndex = 8;
            this.lblGameScoreP1.Text = "Game Score";
            // 
            // txtTurnScoreP1
            // 
            this.txtTurnScoreP1.Location = new System.Drawing.Point(196, 189);
            this.txtTurnScoreP1.Name = "txtTurnScoreP1";
            this.txtTurnScoreP1.ReadOnly = true;
            this.txtTurnScoreP1.Size = new System.Drawing.Size(70, 55);
            this.txtTurnScoreP1.TabIndex = 7;
            this.txtTurnScoreP1.TabStop = false;
            // 
            // lblTurnScoreP1
            // 
            this.lblTurnScoreP1.AutoSize = true;
            this.lblTurnScoreP1.Location = new System.Drawing.Point(6, 189);
            this.lblTurnScoreP1.Name = "lblTurnScoreP1";
            this.lblTurnScoreP1.Size = new System.Drawing.Size(171, 47);
            this.lblTurnScoreP1.TabIndex = 6;
            this.lblTurnScoreP1.Text = "Turn Score";
            // 
            // txtGameScoreP2
            // 
            this.txtGameScoreP2.Location = new System.Drawing.Point(193, 247);
            this.txtGameScoreP2.Name = "txtGameScoreP2";
            this.txtGameScoreP2.ReadOnly = true;
            this.txtGameScoreP2.Size = new System.Drawing.Size(74, 55);
            this.txtGameScoreP2.TabIndex = 15;
            this.txtGameScoreP2.TabStop = false;
            // 
            // gbPlayer2
            // 
            this.gbPlayer2.Controls.Add(this.btnHoldP2);
            this.gbPlayer2.Controls.Add(this.txtGameScoreP2);
            this.gbPlayer2.Controls.Add(this.lblGameScoreP2);
            this.gbPlayer2.Controls.Add(this.btnPlayP2);
            this.gbPlayer2.Controls.Add(this.txtTurnScoreP2);
            this.gbPlayer2.Controls.Add(this.lblTurnScoreP2);
            this.gbPlayer2.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPlayer2.Location = new System.Drawing.Point(323, 105);
            this.gbPlayer2.Name = "gbPlayer2";
            this.gbPlayer2.Size = new System.Drawing.Size(294, 309);
            this.gbPlayer2.TabIndex = 9;
            this.gbPlayer2.TabStop = false;
            this.gbPlayer2.Text = "Player 2";
            // 
            // lblGameScoreP2
            // 
            this.lblGameScoreP2.AutoSize = true;
            this.lblGameScoreP2.Location = new System.Drawing.Point(11, 248);
            this.lblGameScoreP2.Name = "lblGameScoreP2";
            this.lblGameScoreP2.Size = new System.Drawing.Size(184, 47);
            this.lblGameScoreP2.TabIndex = 14;
            this.lblGameScoreP2.Text = "Game Score";
            // 
            // txtTurnScoreP2
            // 
            this.txtTurnScoreP2.Location = new System.Drawing.Point(193, 187);
            this.txtTurnScoreP2.Name = "txtTurnScoreP2";
            this.txtTurnScoreP2.ReadOnly = true;
            this.txtTurnScoreP2.Size = new System.Drawing.Size(74, 55);
            this.txtTurnScoreP2.TabIndex = 13;
            this.txtTurnScoreP2.TabStop = false;
            // 
            // lblTurnScoreP2
            // 
            this.lblTurnScoreP2.AutoSize = true;
            this.lblTurnScoreP2.Location = new System.Drawing.Point(11, 187);
            this.lblTurnScoreP2.Name = "lblTurnScoreP2";
            this.lblTurnScoreP2.Size = new System.Drawing.Size(171, 47);
            this.lblTurnScoreP2.TabIndex = 12;
            this.lblTurnScoreP2.Text = "Turn Score";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Segoe Print", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(116, 420);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(348, 66);
            this.btnNewGame.TabIndex = 16;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pbDice1
            // 
            this.pbDice1.BackgroundImage = global::twoDicePig.Properties.Resources._1;
            this.pbDice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDice1.Location = new System.Drawing.Point(647, 30);
            this.pbDice1.Name = "pbDice1";
            this.pbDice1.Size = new System.Drawing.Size(210, 210);
            this.pbDice1.TabIndex = 10;
            this.pbDice1.TabStop = false;
            // 
            // pbDice2
            // 
            this.pbDice2.BackgroundImage = global::twoDicePig.Properties.Resources._1;
            this.pbDice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDice2.Location = new System.Drawing.Point(647, 264);
            this.pbDice2.Name = "pbDice2";
            this.pbDice2.Size = new System.Drawing.Size(210, 210);
            this.pbDice2.TabIndex = 11;
            this.pbDice2.TabStop = false;
            // 
            // txtTurn
            // 
            this.txtTurn.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurn.Location = new System.Drawing.Point(424, 28);
            this.txtTurn.Name = "txtTurn";
            this.txtTurn.ReadOnly = true;
            this.txtTurn.Size = new System.Drawing.Size(100, 45);
            this.txtTurn.TabIndex = 2;
            this.txtTurn.TabStop = false;
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Segoe Print", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(351, 28);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(67, 36);
            this.lblTurn.TabIndex = 1;
            this.lblTurn.Text = "Turn";
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::twoDicePig.Properties.Resources.Esther_main_image_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(872, 495);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.txtTurn);
            this.Controls.Add(this.pbDice2);
            this.Controls.Add(this.pbDice1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.gbPlayer2);
            this.Controls.Add(this.gbPlayer1);
            this.Controls.Add(this.lblTitle);
            this.Name = "gameForm";
            this.Text = "TWO DICE PIG!!!";
            this.gbPlayer1.ResumeLayout(false);
            this.gbPlayer1.PerformLayout();
            this.gbPlayer2.ResumeLayout(false);
            this.gbPlayer2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnPlayP1;
        private System.Windows.Forms.Button btnHoldP1;
        private System.Windows.Forms.Button btnPlayP2;
        private System.Windows.Forms.Button btnHoldP2;
        private System.Windows.Forms.GroupBox gbPlayer1;
        private System.Windows.Forms.TextBox txtGameScoreP1;
        private System.Windows.Forms.Label lblGameScoreP1;
        private System.Windows.Forms.TextBox txtTurnScoreP1;
        private System.Windows.Forms.Label lblTurnScoreP1;
        private System.Windows.Forms.GroupBox gbPlayer2;
        private System.Windows.Forms.TextBox txtGameScoreP2;
        private System.Windows.Forms.Label lblGameScoreP2;
        private System.Windows.Forms.TextBox txtTurnScoreP2;
        private System.Windows.Forms.Label lblTurnScoreP2;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pbDice1;
        private System.Windows.Forms.PictureBox pbDice2;
        private System.Windows.Forms.TextBox txtTurn;
        private System.Windows.Forms.Label lblTurn;
    }
}

