using System;
using System.Windows.Forms;

namespace Biology_quizz
{
	public partial class EndGame : Form
	{
		public EndGame()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			if(Beginning.countPlayers == 2)
            {
				if (TheGame.tOchki1 > TheGame.tOchki2)
				{
					forWin.Text = $"Победител е {Beginning.igrac1} с {TheGame.tOchki1} точки.";
				}
				else if (TheGame.tOchki1 == TheGame.tOchki2)
				{
					forWin.Text = $"{Beginning.igrac1} и {Beginning.igrac2} са с еднакъв брой точки: {TheGame.tOchki1}";
				}
				else
				{
					forWin.Text = $"Победител е {Beginning.igrac2} с {TheGame.tOchki2} точки.";
				}
            }
			else
            {
				forWin.Text = $"{Beginning.igrac1} изкара {TheGame.tOchki1} точки.";
            }
			countQuestions.Text = $"Бяха зададени {TheGame.indToDisplay} въпроса от общо {TheGame.allQuestions}";
			TheGame.tOchki1 = 0;
			TheGame.tOchki2 = 0;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
