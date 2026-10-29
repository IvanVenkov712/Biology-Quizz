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
	public partial class ChooseName : Form
	{
		public static string name = "";
		public ChooseName()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Beginning.alreadyOpened = false;
			this.Close();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			name = comboBox1.Text;
			this.Close();
			new AddNewQuestion().Show();
		}

		private void ChooseName_Load(object sender, EventArgs e)
		{
			try
			{
				comboBox1.Items.AddRange(Questing.GetQuestNames());
			}
			catch(Exception ex)
			{
				Beginning.alreadyOpened = false;
				MessageBox.Show( "Имената на въпросите не можаха да бъдат разчетени: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close();
			}
		}
	}
}
