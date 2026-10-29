using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biology_quizz
{
	public partial class DeleteQuestion : Form
	{
		public DeleteQuestion()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				File.Delete($"Added Questions\\{textBox1.Text}.qst");
				textBox1.Items.Clear();
				textBox1.Items.AddRange(Questing.GetQuestNames());
				MessageBox.Show("Въпросът бе изтрит успешно");
			}
			catch
            {
				MessageBox.Show("Няма въпрос с такова име", "Грешка");
            }
		}

        private void DeleteQuestion_FormClosed(object sender, FormClosedEventArgs e)
        {
			Beginning.alreadyOpened = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
			this.Close();
        }

        private void DeleteQuestion_Load(object sender, EventArgs e)
        {
			textBox1.Items.AddRange(Questing.GetQuestNames());
        }
    }
}
