
namespace SpaceInvaders
{
    partial class Space
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Space));
            this.LzrCan = new System.Windows.Forms.PictureBox();
            this.Life1 = new System.Windows.Forms.PictureBox();
            this.Life2 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.ScoreNumLabel = new System.Windows.Forms.Label();
            this.LevelNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LzrCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).BeginInit();
            this.SuspendLayout();
            // 
            // LzrCan
            // 
            this.LzrCan.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LzrCan.Image = global::SpaceInvaders.Properties.Resources.LaserCannon;
            this.LzrCan.InitialImage = ((System.Drawing.Image)(resources.GetObject("LzrCan.InitialImage")));
            this.LzrCan.Location = new System.Drawing.Point(335, 541);
            this.LzrCan.Name = "LzrCan";
            this.LzrCan.Size = new System.Drawing.Size(50, 50);
            this.LzrCan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LzrCan.TabIndex = 0;
            this.LzrCan.TabStop = false;
            this.LzrCan.Tag = "Cannon";
            // 
            // Life1
            // 
            this.Life1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Life1.Image = global::SpaceInvaders.Properties.Resources.LaserCannon;
            this.Life1.InitialImage = ((System.Drawing.Image)(resources.GetObject("Life1.InitialImage")));
            this.Life1.Location = new System.Drawing.Point(66, 13);
            this.Life1.Name = "Life1";
            this.Life1.Size = new System.Drawing.Size(50, 50);
            this.Life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Life1.TabIndex = 77;
            this.Life1.TabStop = false;
            this.Life1.Tag = "Cannon";
            // 
            // Life2
            // 
            this.Life2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Life2.Image = global::SpaceInvaders.Properties.Resources.LaserCannon;
            this.Life2.InitialImage = ((System.Drawing.Image)(resources.GetObject("Life2.InitialImage")));
            this.Life2.Location = new System.Drawing.Point(10, 13);
            this.Life2.Name = "Life2";
            this.Life2.Size = new System.Drawing.Size(50, 50);
            this.Life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Life2.TabIndex = 76;
            this.Life2.TabStop = false;
            this.Life2.Tag = "Cannon";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 500;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(325, 9);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(69, 25);
            this.ScoreLabel.TabIndex = 82;
            this.ScoreLabel.Tag = "Labels";
            this.ScoreLabel.Text = "Score\r\n";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(626, 13);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(64, 25);
            this.LevelLabel.TabIndex = 83;
            this.LevelLabel.Tag = "Labels";
            this.LevelLabel.Text = "Level";
            // 
            // ScoreNumLabel
            // 
            this.ScoreNumLabel.AutoSize = true;
            this.ScoreNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreNumLabel.Location = new System.Drawing.Point(351, 43);
            this.ScoreNumLabel.Name = "ScoreNumLabel";
            this.ScoreNumLabel.Size = new System.Drawing.Size(18, 20);
            this.ScoreNumLabel.TabIndex = 84;
            this.ScoreNumLabel.Tag = "Labels";
            this.ScoreNumLabel.Text = "0";
            // 
            // LevelNumLabel
            // 
            this.LevelNumLabel.AutoSize = true;
            this.LevelNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelNumLabel.Location = new System.Drawing.Point(651, 43);
            this.LevelNumLabel.Name = "LevelNumLabel";
            this.LevelNumLabel.Size = new System.Drawing.Size(18, 20);
            this.LevelNumLabel.TabIndex = 85;
            this.LevelNumLabel.Tag = "Labels";
            this.LevelNumLabel.Text = "1";
            // 
            // Space
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(702, 603);
            this.Controls.Add(this.LevelNumLabel);
            this.Controls.Add(this.ScoreNumLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Life1);
            this.Controls.Add(this.Life2);
            this.Controls.Add(this.LzrCan);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Space";
            this.Text = "Space Invaders";
            this.Shown += new System.EventHandler(this.Space_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpaceInvaders_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.LzrCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LzrCan;
        private System.Windows.Forms.PictureBox Life1;
        private System.Windows.Forms.PictureBox Life2;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label ScoreNumLabel;
        private System.Windows.Forms.Label LevelNumLabel;
    }
}

