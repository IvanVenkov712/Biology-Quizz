namespace Biology_quizz
{
    partial class Beginning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beginning));
            this.label2 = new System.Windows.Forms.Label();
            this.igr1 = new System.Windows.Forms.TextBox();
            this.startGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addQuest = new System.Windows.Forms.Button();
            this.deleteQuest = new System.Windows.Forms.Button();
            this.editQuest = new System.Windows.Forms.Button();
            this.CountPlayers = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.igr2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CountPlayers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(185, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име на играч 2: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // igr1
            // 
            this.igr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.igr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.igr1.Location = new System.Drawing.Point(347, 90);
            this.igr1.Name = "igr1";
            this.igr1.Size = new System.Drawing.Size(157, 29);
            this.igr1.TabIndex = 2;
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startGame.ForeColor = System.Drawing.Color.Green;
            this.startGame.Location = new System.Drawing.Point(191, 34);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(268, 62);
            this.startGame.TabIndex = 4;
            this.startGame.Text = "Започни играта";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(278, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Изход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addQuest
            // 
            this.addQuest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addQuest.Location = new System.Drawing.Point(52, 112);
            this.addQuest.Name = "addQuest";
            this.addQuest.Size = new System.Drawing.Size(180, 50);
            this.addQuest.TabIndex = 6;
            this.addQuest.Text = "Добави нов въпрос";
            this.addQuest.UseVisualStyleBackColor = false;
            this.addQuest.Click += new System.EventHandler(this.addQuest_Click);
            // 
            // deleteQuest
            // 
            this.deleteQuest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteQuest.Location = new System.Drawing.Point(424, 112);
            this.deleteQuest.Name = "deleteQuest";
            this.deleteQuest.Size = new System.Drawing.Size(180, 50);
            this.deleteQuest.TabIndex = 8;
            this.deleteQuest.Text = "Изтрий въпрос";
            this.deleteQuest.UseVisualStyleBackColor = false;
            this.deleteQuest.Click += new System.EventHandler(this.deleteQuest_Click);
            // 
            // editQuest
            // 
            this.editQuest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editQuest.Location = new System.Drawing.Point(238, 112);
            this.editQuest.Name = "editQuest";
            this.editQuest.Size = new System.Drawing.Size(180, 50);
            this.editQuest.TabIndex = 9;
            this.editQuest.Text = "Редактирай въпрос";
            this.editQuest.UseVisualStyleBackColor = false;
            this.editQuest.Click += new System.EventHandler(this.editQuest_Click);
            // 
            // CountPlayers
            // 
            this.CountPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountPlayers.Location = new System.Drawing.Point(349, 42);
            this.CountPlayers.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.CountPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountPlayers.Name = "CountPlayers";
            this.CountPlayers.ReadOnly = true;
            this.CountPlayers.Size = new System.Drawing.Size(41, 29);
            this.CountPlayers.TabIndex = 10;
            this.CountPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CountPlayers.ValueChanged += new System.EventHandler(this.CountPlayers_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(218, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Брой играчи";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(185, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на играч 1: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // igr2
            // 
            this.igr2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.igr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.igr2.Location = new System.Drawing.Point(347, 137);
            this.igr2.Name = "igr2";
            this.igr2.Size = new System.Drawing.Size(157, 29);
            this.igr2.TabIndex = 3;
            this.igr2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.editQuest);
            this.panel1.Controls.Add(this.deleteQuest);
            this.panel1.Controls.Add(this.addQuest);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.startGame);
            this.panel1.Location = new System.Drawing.Point(10, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 250);
            this.panel1.TabIndex = 12;
            // 
            // Beginning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Biology_quizz.Properties.Resources.cianobacterii_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CountPlayers);
            this.Controls.Add(this.igr2);
            this.Controls.Add(this.igr1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Beginning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beginning";
            this.Load += new System.EventHandler(this.Beginning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CountPlayers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox igr1;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addQuest;
        private System.Windows.Forms.Button deleteQuest;
        private System.Windows.Forms.Button editQuest;
        private System.Windows.Forms.NumericUpDown CountPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox igr2;
        private System.Windows.Forms.Panel panel1;
    }
}