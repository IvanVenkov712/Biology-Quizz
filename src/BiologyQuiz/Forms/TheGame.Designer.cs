namespace Biology_quizz
{
    partial class TheGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheGame));
            this.next = new System.Windows.Forms.Button();
            this.vapros = new System.Windows.Forms.Label();
            this.igrach = new System.Windows.Forms.Label();
            this.tochki1 = new System.Windows.Forms.Label();
            this.tochki2 = new System.Windows.Forms.Label();
            this.zaOtgovor = new System.Windows.Forms.Label();
            this.stopGame = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Label();
            this.two = new System.Windows.Forms.Label();
            this.tree = new System.Windows.Forms.Label();
            this.four = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.otg3 = new System.Windows.Forms.PictureBox();
            this.otg4 = new System.Windows.Forms.PictureBox();
            this.otg2 = new System.Windows.Forms.PictureBox();
            this.otg1 = new System.Windows.Forms.PictureBox();
            this.vaprNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otg1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.ForeColor = System.Drawing.Color.DarkGreen;
            this.next.Location = new System.Drawing.Point(573, 662);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(200, 100);
            this.next.TabIndex = 0;
            this.next.Text = "Следващ ";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // vapros
            // 
            this.vapros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vapros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vapros.Location = new System.Drawing.Point(22, 411);
            this.vapros.Name = "vapros";
            this.vapros.Size = new System.Drawing.Size(500, 155);
            this.vapros.TabIndex = 7;
            this.vapros.Text = "Това е образователна игра, свързана с клетката като част от организма. Съдържа 25" +
    "0 въпроса. Учете забавлявайки  се.";
            this.vapros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // igrach
            // 
            this.igrach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.igrach.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.igrach.ForeColor = System.Drawing.Color.Red;
            this.igrach.Location = new System.Drawing.Point(88, 576);
            this.igrach.Name = "igrach";
            this.igrach.Size = new System.Drawing.Size(350, 50);
            this.igrach.TabIndex = 8;
            this.igrach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tochki1
            // 
            this.tochki1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tochki1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tochki1.ForeColor = System.Drawing.Color.Red;
            this.tochki1.Location = new System.Drawing.Point(22, 651);
            this.tochki1.Name = "tochki1";
            this.tochki1.Size = new System.Drawing.Size(500, 50);
            this.tochki1.TabIndex = 9;
            this.tochki1.Text = "Точки на : ";
            this.tochki1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tochki1.Visible = false;
            // 
            // tochki2
            // 
            this.tochki2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tochki2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tochki2.ForeColor = System.Drawing.Color.Blue;
            this.tochki2.Location = new System.Drawing.Point(22, 712);
            this.tochki2.Name = "tochki2";
            this.tochki2.Size = new System.Drawing.Size(500, 50);
            this.tochki2.TabIndex = 10;
            this.tochki2.Text = "Точки на : ";
            this.tochki2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tochki2.Visible = false;
            // 
            // zaOtgovor
            // 
            this.zaOtgovor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zaOtgovor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zaOtgovor.ForeColor = System.Drawing.Color.Green;
            this.zaOtgovor.Location = new System.Drawing.Point(1064, 668);
            this.zaOtgovor.Name = "zaOtgovor";
            this.zaOtgovor.Size = new System.Drawing.Size(200, 100);
            this.zaOtgovor.TabIndex = 11;
            this.zaOtgovor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stopGame
            // 
            this.stopGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stopGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopGame.ForeColor = System.Drawing.Color.Red;
            this.stopGame.Location = new System.Drawing.Point(804, 664);
            this.stopGame.Name = "stopGame";
            this.stopGame.Size = new System.Drawing.Size(200, 100);
            this.stopGame.TabIndex = 12;
            this.stopGame.Text = "Спри играта ";
            this.stopGame.UseVisualStyleBackColor = true;
            this.stopGame.Click += new System.EventHandler(this.StopGame_Click);
            // 
            // one
            // 
            this.one.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(642, 24);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(400, 120);
            this.one.TabIndex = 13;
            this.one.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // two
            // 
            this.two.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(642, 166);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(400, 120);
            this.two.TabIndex = 14;
            this.two.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tree
            // 
            this.tree.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tree.Location = new System.Drawing.Point(642, 321);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(400, 120);
            this.tree.TabIndex = 15;
            this.tree.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // four
            // 
            this.four.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(642, 477);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(400, 120);
            this.four.TabIndex = 16;
            this.four.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pic
            // 
            this.pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Location = new System.Drawing.Point(22, 95);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(500, 300);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 6;
            this.pic.TabStop = false;
            // 
            // otg3
            // 
            this.otg3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.otg3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otg3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otg3.Location = new System.Drawing.Point(1069, 325);
            this.otg3.Name = "otg3";
            this.otg3.Size = new System.Drawing.Size(200, 120);
            this.otg3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.otg3.TabIndex = 5;
            this.otg3.TabStop = false;
            this.otg3.Click += new System.EventHandler(this.otg3_Click);
            // 
            // otg4
            // 
            this.otg4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.otg4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otg4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otg4.Location = new System.Drawing.Point(1069, 466);
            this.otg4.Name = "otg4";
            this.otg4.Size = new System.Drawing.Size(200, 120);
            this.otg4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.otg4.TabIndex = 4;
            this.otg4.TabStop = false;
            this.otg4.Click += new System.EventHandler(this.otg4_Click);
            // 
            // otg2
            // 
            this.otg2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.otg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otg2.Location = new System.Drawing.Point(1069, 170);
            this.otg2.Name = "otg2";
            this.otg2.Size = new System.Drawing.Size(200, 120);
            this.otg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.otg2.TabIndex = 2;
            this.otg2.TabStop = false;
            this.otg2.Click += new System.EventHandler(this.otg2_Click);
            // 
            // otg1
            // 
            this.otg1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.otg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.otg1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.otg1.Location = new System.Drawing.Point(1069, 28);
            this.otg1.Name = "otg1";
            this.otg1.Size = new System.Drawing.Size(200, 120);
            this.otg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.otg1.TabIndex = 1;
            this.otg1.TabStop = false;
            this.otg1.Click += new System.EventHandler(this.otg1_Click);
            // 
            // vaprNum
            // 
            this.vaprNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vaprNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vaprNum.Location = new System.Drawing.Point(22, 24);
            this.vaprNum.Name = "vaprNum";
            this.vaprNum.Size = new System.Drawing.Size(500, 56);
            this.vaprNum.TabIndex = 17;
            this.vaprNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vaprNum);
            this.panel1.Controls.Add(this.four);
            this.panel1.Controls.Add(this.tree);
            this.panel1.Controls.Add(this.two);
            this.panel1.Controls.Add(this.one);
            this.panel1.Controls.Add(this.stopGame);
            this.panel1.Controls.Add(this.tochki2);
            this.panel1.Controls.Add(this.tochki1);
            this.panel1.Controls.Add(this.igrach);
            this.panel1.Controls.Add(this.vapros);
            this.panel1.Controls.Add(this.pic);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.otg1);
            this.panel1.Controls.Add(this.otg2);
            this.panel1.Controls.Add(this.otg3);
            this.panel1.Controls.Add(this.otg4);
            this.panel1.Controls.Add(this.zaOtgovor);
            this.panel1.Location = new System.Drawing.Point(7, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 790);
            this.panel1.TabIndex = 18;
            // 
            // TheGame
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1372, 811);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TheGame";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.TheGame_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otg1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.PictureBox otg1;
        private System.Windows.Forms.PictureBox otg2;
        private System.Windows.Forms.PictureBox otg4;
        private System.Windows.Forms.PictureBox otg3;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label vapros;
        private System.Windows.Forms.Label igrach;
        private System.Windows.Forms.Label tochki1;
        private System.Windows.Forms.Label tochki2;
        private System.Windows.Forms.Label zaOtgovor;
        private System.Windows.Forms.Button stopGame;
        private System.Windows.Forms.Label one;
        private System.Windows.Forms.Label two;
        private System.Windows.Forms.Label tree;
        private System.Windows.Forms.Label four;
        private System.Windows.Forms.Label vaprNum;
        private System.Windows.Forms.Panel panel1;
    }
}
