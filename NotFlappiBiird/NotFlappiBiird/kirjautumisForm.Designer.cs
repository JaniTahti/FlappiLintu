
namespace NotFlappiBiird
{
    partial class kirjautumisForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ktunnusTB = new System.Windows.Forms.TextBox();
            this.kirjautuminenLB = new System.Windows.Forms.Label();
            this.ktunnusLB = new System.Windows.Forms.Label();
            this.salasanaLB = new System.Windows.Forms.Label();
            this.salasanaTB = new System.Windows.Forms.TextBox();
            this.naytaBT = new System.Windows.Forms.Button();
            this.uusiBT = new System.Windows.Forms.Button();
            this.kirjauduBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NotFlappiBiird.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(40, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(360, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ktunnusTB
            // 
            this.ktunnusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktunnusTB.Location = new System.Drawing.Point(162, 357);
            this.ktunnusTB.Name = "ktunnusTB";
            this.ktunnusTB.Size = new System.Drawing.Size(260, 29);
            this.ktunnusTB.TabIndex = 1;
            // 
            // kirjautuminenLB
            // 
            this.kirjautuminenLB.AutoSize = true;
            this.kirjautuminenLB.BackColor = System.Drawing.Color.PeachPuff;
            this.kirjautuminenLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjautuminenLB.Location = new System.Drawing.Point(58, 271);
            this.kirjautuminenLB.Name = "kirjautuminenLB";
            this.kirjautuminenLB.Size = new System.Drawing.Size(330, 55);
            this.kirjautuminenLB.TabIndex = 2;
            this.kirjautuminenLB.Text = "Kirjautuminen";
            // 
            // ktunnusLB
            // 
            this.ktunnusLB.AutoSize = true;
            this.ktunnusLB.BackColor = System.Drawing.Color.PeachPuff;
            this.ktunnusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktunnusLB.Location = new System.Drawing.Point(15, 357);
            this.ktunnusLB.Name = "ktunnusLB";
            this.ktunnusLB.Size = new System.Drawing.Size(141, 25);
            this.ktunnusLB.TabIndex = 3;
            this.ktunnusLB.Text = "Käyttäjänimi";
            // 
            // salasanaLB
            // 
            this.salasanaLB.AutoSize = true;
            this.salasanaLB.BackColor = System.Drawing.Color.PeachPuff;
            this.salasanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaLB.Location = new System.Drawing.Point(5, 409);
            this.salasanaLB.Name = "salasanaLB";
            this.salasanaLB.Size = new System.Drawing.Size(110, 25);
            this.salasanaLB.TabIndex = 5;
            this.salasanaLB.Text = "Salasana";
            // 
            // salasanaTB
            // 
            this.salasanaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salasanaTB.Location = new System.Drawing.Point(162, 409);
            this.salasanaTB.Name = "salasanaTB";
            this.salasanaTB.Size = new System.Drawing.Size(260, 29);
            this.salasanaTB.TabIndex = 4;
            this.salasanaTB.UseSystemPasswordChar = true;
            // 
            // naytaBT
            // 
            this.naytaBT.BackColor = System.Drawing.Color.Gold;
            this.naytaBT.Location = new System.Drawing.Point(121, 411);
            this.naytaBT.Name = "naytaBT";
            this.naytaBT.Size = new System.Drawing.Size(35, 23);
            this.naytaBT.TabIndex = 6;
            this.naytaBT.Text = "näy.";
            this.naytaBT.UseVisualStyleBackColor = false;
            this.naytaBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // uusiBT
            // 
            this.uusiBT.BackColor = System.Drawing.Color.PeachPuff;
            this.uusiBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uusiBT.Location = new System.Drawing.Point(12, 501);
            this.uusiBT.Name = "uusiBT";
            this.uusiBT.Size = new System.Drawing.Size(410, 48);
            this.uusiBT.TabIndex = 7;
            this.uusiBT.Text = "Luo käyttäjä";
            this.uusiBT.UseVisualStyleBackColor = false;
            // 
            // kirjauduBT
            // 
            this.kirjauduBT.BackColor = System.Drawing.Color.PeachPuff;
            this.kirjauduBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjauduBT.Location = new System.Drawing.Point(12, 447);
            this.kirjauduBT.Name = "kirjauduBT";
            this.kirjauduBT.Size = new System.Drawing.Size(410, 48);
            this.kirjauduBT.TabIndex = 8;
            this.kirjauduBT.Text = "Kirjaudu sisään";
            this.kirjauduBT.UseVisualStyleBackColor = false;
            this.kirjauduBT.Click += new System.EventHandler(this.kirjauduBT_Click);
            // 
            // kirjautumisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.kirjauduBT);
            this.Controls.Add(this.uusiBT);
            this.Controls.Add(this.naytaBT);
            this.Controls.Add(this.salasanaLB);
            this.Controls.Add(this.salasanaTB);
            this.Controls.Add(this.ktunnusLB);
            this.Controls.Add(this.kirjautuminenLB);
            this.Controls.Add(this.ktunnusTB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "kirjautumisForm";
            this.Text = "kirjautumisForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.kirjautumisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ktunnusTB;
        private System.Windows.Forms.Label kirjautuminenLB;
        private System.Windows.Forms.Label ktunnusLB;
        private System.Windows.Forms.Label salasanaLB;
        private System.Windows.Forms.TextBox salasanaTB;
        private System.Windows.Forms.Button naytaBT;
        private System.Windows.Forms.Button uusiBT;
        private System.Windows.Forms.Button kirjauduBT;
    }
}