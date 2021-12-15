
namespace NotFlappiBiird
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
            this.components = new System.ComponentModel.Container();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.Flappi = new System.Windows.Forms.PictureBox();
            this.scoretext = new System.Windows.Forms.Label();
            this.gamertimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappi)).BeginInit();
            this.SuspendLayout();
            // 
            // PipeTop
            // 
            this.PipeTop.BackColor = System.Drawing.Color.Green;
            this.PipeTop.Location = new System.Drawing.Point(416, -81);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(100, 403);
            this.PipeTop.TabIndex = 0;
            this.PipeTop.TabStop = false;
            this.PipeTop.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PipeBottom
            // 
            this.PipeBottom.BackColor = System.Drawing.Color.Green;
            this.PipeBottom.Location = new System.Drawing.Point(546, 512);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(100, 145);
            this.PipeBottom.TabIndex = 1;
            this.PipeBottom.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Ground.Location = new System.Drawing.Point(-10, 650);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(748, 72);
            this.Ground.TabIndex = 2;
            this.Ground.TabStop = false;
            // 
            // Flappi
            // 
            this.Flappi.BackColor = System.Drawing.Color.Yellow;
            this.Flappi.Location = new System.Drawing.Point(64, 351);
            this.Flappi.Name = "Flappi";
            this.Flappi.Size = new System.Drawing.Size(81, 50);
            this.Flappi.TabIndex = 3;
            this.Flappi.TabStop = false;
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(34, 29);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(96, 28);
            this.scoretext.TabIndex = 4;
            this.scoretext.Text = "Score: 0";
            // 
            // gamertimer
            // 
            this.gamertimer.Enabled = true;
            this.gamertimer.Interval = 20;
            this.gamertimer.Tick += new System.EventHandler(this.GamerTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(646, 721);
            this.Controls.Add(this.Flappi);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.PipeTop);
            this.MaximumSize = new System.Drawing.Size(662, 760);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamerkeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamerkeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flappi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Flappi;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Timer gamertimer;
    }
}

