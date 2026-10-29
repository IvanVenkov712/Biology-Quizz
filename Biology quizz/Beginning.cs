using System;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Biology_quizz
{
    public partial class Beginning : Form
	{
		public static string[] players;
		public static string igrac1 = "";
		public static string igrac2 = "";
		public static bool alreadyOpened = false;
		public static bool questOpened = false;
		public static int opt = 0;
		public static decimal countPlayers = 1;
		public Beginning()
		{
			InitializeComponent();
		}
		private void startGame_Click(object sender, EventArgs e)
		{
			if (!alreadyOpened)
			{
				igrac1 = igr1.Text;
				igrac2 = igr2.Text;
				if ((!(igrac1 == string.Empty || igrac2 == string.Empty)) || (countPlayers == 1 && !(igrac1 == string.Empty)))
				{						
					label2.ForeColor = Color.Black;
					label1.ForeColor = Color.Black;
					new TheGame().Show();
					alreadyOpened = true;
				}
				else
                {
					if (igrac1 == string.Empty && !(igrac2 == string.Empty))
					{
						label1.ForeColor = Color.Red;
						label2.ForeColor = Color.Black;
					}
					else if (igrac2 == string.Empty && !(igrac1 == string.Empty))
					{
						label2.ForeColor = Color.Red;
						label1.ForeColor = Color.Black;
					}
					else if (countPlayers == 2)
					{
						label1.ForeColor = Color.Red;
						label2.ForeColor = Color.Red;
					}
					else
					{
						label1.ForeColor = Color.Red;
						label2.ForeColor = Color.Black;
					}
				}
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			/*
			Question.ImportFromDirectory("Added Questions\\Въпрос за оперона").ExportToFile("Added Questions\\Въпрос_за_оперона.qst");
			
			string[] dirs = Directory.GetDirectories("Added Questions");
			for(int i = 0; i < dirs.Length; i++)
			{
				try
				{
					if (!File.Exists(dirs[i] + ".qst")) Question.ImportFromDirectory(dirs[i]).ExportToFile($"{dirs[i]}.qst");
				}
                catch
                {
					continue;
                }
			}
			*/
			this.Close();
		}

        private void Beginning_Load(object sender, EventArgs e)
        {
			if(!(Directory.Exists("Added Questions")))
            {
				Directory.CreateDirectory("Added Questions");
            }

        }
        private void addQuest_Click(object sender, EventArgs e)
        {
			if (!(Beginning.alreadyOpened))
			{
				new Password().Show();
				opt = 0;
				Beginning.alreadyOpened = true;
			}
        }

        private void deleteQuest_Click(object sender, EventArgs e)
        {
			if (!(Beginning.alreadyOpened))
			{
				new Password().Show();
				opt = 2;
				Beginning.alreadyOpened = true;
			}
		}

        private void editQuest_Click(object sender, EventArgs e)
        {
			if (!(Beginning.alreadyOpened))
			{
				new Password().Show();
				opt = 1;
				Beginning.alreadyOpened = true;
			}
		}
        private void CountPlayers_ValueChanged(object sender, EventArgs e)
        {
			countPlayers = CountPlayers.Value;
			if(CountPlayers.Value == 1)
            {
				label2.Visible = false;
				igr2.Visible = false;
            }
			else if (CountPlayers.Value == 2)
			{
				label2.Visible = true;
				igr2.Visible = true;
			}
		}
    }
}
