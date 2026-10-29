namespace Biology_quizz
{
    partial class EndGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndGame));
            this.restart = new System.Windows.Forms.Button();
            this.forWin = new System.Windows.Forms.Label();
            this.countQuestions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restart.ForeColor = System.Drawing.Color.Green;
            this.restart.Location = new System.Drawing.Point(110, 278);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(538, 91);
            this.restart.TabIndex = 0;
            this.restart.Text = "Затвори";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.button1_Click);
            // 
            // forWin
            // 
            this.forWin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.forWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forWin.ForeColor = System.Drawing.Color.Black;
            this.forWin.Location = new System.Drawing.Point(115, 39);
            this.forWin.Name = "forWin";
            this.forWin.Size = new System.Drawing.Size(533, 157);
            this.forWin.TabIndex = 1;
            this.forWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countQuestions
            // 
            this.countQuestions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.countQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countQuestions.ForeColor = System.Drawing.Color.Black;
            this.countQuestions.Location = new System.Drawing.Point(113, 210);
            this.countQuestions.Name = "countQuestions";
            this.countQuestions.Size = new System.Drawing.Size(535, 53);
            this.countQuestions.TabIndex = 2;
            this.countQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Biology_quizz.Properties.Resources.cianobacterii_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(734, 381);
            this.Controls.Add(this.countQuestions);
            this.Controls.Add(this.forWin);
            this.Controls.Add(this.restart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "End of Game";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label forWin;
        private System.Windows.Forms.Label countQuestions;
    }
}