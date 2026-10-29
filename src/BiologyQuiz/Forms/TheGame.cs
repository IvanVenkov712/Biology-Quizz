using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Biology_quizz
{
	public partial class TheGame : Form
	{
		#region programActions
		public static int tOchki1 = 0, tOchki2 = 0, allQuestions = 0, indToDisplay = 0;
		int votgovor = 0;
		bool pressGuard = false, secondPlayerTurn = false, dadOtg = true;
		List<string> questNames;

		public TheGame()
		{
			InitializeComponent();
		}
		private void Form1_Closed(object sender, EventArgs e)
		{
			Beginning.alreadyOpened = false;
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			indToDisplay = 0;
			if (this.ClientSize.Width > this.panel1.Width) this.panel1.Left = (this.ClientSize.Width - this.panel1.Width) / 2;
			if (this.ClientSize.Height > this.panel1.Height) this.panel1.Top = (this.ClientSize.Height - this.panel1.Height) / 2;
			
			tochki1.Visible = true;
			tochki1.Text = "Точки на " + Beginning.igrac1 + ": " + tOchki1;
			if (Beginning.countPlayers == 2)
			{
				tochki2.Visible = true;
				tochki2.Text = "Точки на " + Beginning.igrac2 + ": " + tOchki2;
			}
			questNames = new List<string>(Directory.GetFiles("Added Questions"));
			allQuestions = questNames.Count;
		}
		private void next_Click(object sender, EventArgs e)
		{
			if (dadOtg)
			{
				if (questNames.Count > 0)
				{
					indToDisplay++;
					while(questNames.Count > 0)
                    {
						int index = new Random().Next(questNames.Count);
						try
                        {
							LoadQuest(Question.ImportFromFile(questNames[index]));
							questNames.RemoveAt(index);
							break;
						}
						catch
                        {
							allQuestions--;
							if (File.Exists(questNames[index])) File.Delete(questNames[index]);
							questNames.RemoveAt(index);
							MessageBox.Show("Беше открита грешка при задаването на въпроса.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							if (questNames.Count == 0)
                            {
								this.Close();
								new EndGame().Show();
							}
						}
					}
					if (secondPlayerTurn && Beginning.countPlayers == 2)
					{
						igrach.ForeColor = Color.Blue;
						igrach.Text = Beginning.igrac2;
					}
					else
					{
						igrach.ForeColor = Color.Red;
						igrach.Text = Beginning.igrac1;
					}
					zaOtgovor.Text = "";
					vaprNum.Text = $"Въпрос {indToDisplay} от {allQuestions}";
					pressGuard = true;
					dadOtg = false;
				}
				else
				{
					this.Close();
					new EndGame().Show();
				}
			}
			else
			{
				zaOtgovor.Text = "Отговорете на въпроса!";
				zaOtgovor.ForeColor = Color.Red;
			}
		}
		void PicturesCode(int otg)
		{
			if (votgovor == otg && pressGuard)
			{
				zaOtgovor.Text = "Верен отговор!";
				zaOtgovor.ForeColor = Color.Green;
				votgovor = 0;
				if (secondPlayerTurn && Beginning.countPlayers == 2)
				{
					tOchki2 += 3;
					tochki2.Text = $"Точки на {Beginning.igrac2}: {tOchki2}";
				}
				else
				{
					tOchki1 += 3;
					tochki1.Text = $"Точки на {Beginning.igrac1}: {tOchki1}";
				}
			}
			else if (pressGuard)
			{
				zaOtgovor.Text = "Грешен отговор!";
				zaOtgovor.ForeColor = Color.Red;
			}
			secondPlayerTurn = (!secondPlayerTurn);
			pressGuard = false;
			dadOtg = true;
		}

		private void otg1_Click(object sender, EventArgs e)
		{
			PicturesCode(1);
		}


        private void otg2_Click(object sender, EventArgs e)
		{
			PicturesCode(2);
		}
		private void otg3_Click(object sender, EventArgs e)
		{
			PicturesCode(3);
		}
		private void otg4_Click(object sender, EventArgs e)
		{
			PicturesCode(4);
		}        
		private void TheGame_SizeChanged(object sender, EventArgs e)
        {
			if (this.ClientSize.Width > this.panel1.Width) this.panel1.Left = (this.ClientSize.Width - this.panel1.Width) / 2;
			if (this.ClientSize.Height > this.panel1.Height) this.panel1.Top = (this.ClientSize.Height - this.panel1.Height) / 2;
		}
		private void StopGame_Click(object sender, EventArgs e)
		{
			if (!secondPlayerTurn || Beginning.countPlayers == 1)
			{
				this.Close();
				new EndGame().Show();
			}
			else
			{
				zaOtgovor.Text = "Изчакайте " + Beginning.igrac2 + "!";
				zaOtgovor.ForeColor = Color.Red;
			}
		}
		void LoadQuest(Question v)
		{
			one.Text = v.OptLabels[0];
			two.Text = v.OptLabels[1];
			tree.Text = v.OptLabels[2];
			four.Text = v.OptLabels[3];
			otg1.Image = v.Options[0];
			otg2.Image = v.Options[1];
			otg3.Image = v.Options[2];
			otg4.Image = v.Options[3];
			pic.Image = v.ImageToQuest;
			vapros.Text = v.Condition;
			votgovor =  v.Answer;
		}
		#endregion
	}
}
