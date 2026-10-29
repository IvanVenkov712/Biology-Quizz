using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biology_quizz
{
	public partial class Password : Form
	{
        readonly string defPassword = "MyPassword1234";
		public Password()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text == defPassword)
			{
				if (Beginning.opt == 0) new AddNewQuestion().Show();
				else if (Beginning.opt == 1) new ChooseName().Show();
				else if (Beginning.opt == 2) new DeleteQuestion().Show();
				this.Close();
			}
			else
			{
				textBox1.Text = "";
				MessageBox.Show("Грешна парола! Опитайте пак");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Password_FormClosed(object sender, FormClosedEventArgs e)
		{
			Beginning.alreadyOpened = false;
		}
	}
}
