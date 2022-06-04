
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class PlayGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.playButton = new System.Windows.Forms.Label();
            this.nameOfGame = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.playButton.ForeColor = System.Drawing.Color.Moccasin;
            this.playButton.Image = ((System.Drawing.Image)(resources.GetObject("playButton.Image")));
            this.playButton.Location = new System.Drawing.Point(301, 460);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(424, 100);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "  PLAY GAME";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.playButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayButton_MouseClick);
            // 
            // nameOfGame
            // 
            this.nameOfGame.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameOfGame.ForeColor = System.Drawing.Color.Moccasin;
            this.nameOfGame.Image = ((System.Drawing.Image)(resources.GetObject("nameOfGame.Image")));
            this.nameOfGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nameOfGame.Location = new System.Drawing.Point(236, -4);
            this.nameOfGame.Name = "nameOfGame";
            this.nameOfGame.Size = new System.Drawing.Size(550, 164);
            this.nameOfGame.TabIndex = 1;
            this.nameOfGame.Text = "  Cats and Scientists";
            this.nameOfGame.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.Control;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordBox.Location = new System.Drawing.Point(389, 571);
            this.passwordBox.Multiline = true;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(266, 63);
            this.passwordBox.TabIndex = 2;
            // 
            // PlayGame
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1026, 836);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.nameOfGame);
            this.Controls.Add(this.playButton);
            this.Name = "PlayGame";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label playButton;
        private System.Windows.Forms.Label nameOfGame;
        private System.Windows.Forms.TextBox passwordBox;
        private Timer timer1;
    }
}

