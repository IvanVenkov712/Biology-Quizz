using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biology_quizz
{
	public partial class AddNewQuestion : Form
	{
		public static OpenFileDialog defFileDial;

		public bool EverythingIsNotNull()
		{
			bool res = nameString.Text != "";
			res = res && comboBox1.Text != "";
			res = res && uslovie.Text != "";
			res = res && opcia1.Text != "";
			res = res && opcia2.Text != "";
			res = res && opcia3.Text != "";
			res = res && opcia4.Text != "";
			res = res && (!(picForQuestion.Image == null || picForQuestion.Image == Properties.Resources.plusPicture_copy));
			res = res && (!(picOpt1.Image == null || picOpt1.Image == Properties.Resources.plusPicture_copy));
			res = res && (!(picOpt2.Image == null || picOpt2.Image == Properties.Resources.plusPicture_copy));
			res = res && (!(picOpt3.Image == null || picOpt3.Image == Properties.Resources.plusPicture_copy));
			res = res && (!(picOpt4.Image == null || picOpt4.Image == Properties.Resources.plusPicture_copy));
			return res;
		}
		public Question ReadFromControls()
		{
			Question res = new Question
			{
				Answer = int.Parse(comboBox1.Text),
				ImageToQuest = picForQuestion.Image,
				OptLabels = new string[] { opcia1.Text, opcia2.Text, opcia3.Text, opcia4.Text },
				Options = new Image[] { picOpt1.Image, picOpt2.Image, picOpt3.Image, picOpt4.Image },
				Condition = uslovie.Text
			};
			return res;
		}
		public void ClearAll()
		{
			uslovie.Text = opcia1.Text = opcia2.Text = opcia3.Text = opcia4.Text = nameString.Text = "";
			picForQuestion.Image = picOpt1.Image = picOpt2.Image = picOpt3.Image = picOpt4.Image = Properties.Resources.plusPicture_copy;
			comboBox1.Text = "";
		}
		public AddNewQuestion()
		{
			InitializeComponent();
			defFileDial = new OpenFileDialog()
			{
				InitialDirectory = DriveInfo.GetDrives()[0].RootDirectory.FullName,
				RestoreDirectory = true,
				Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg|All files (*.*)|*.*",
				FilterIndex = 0,
				Title = "Изберете изображение"
			};
		}
		private void createQuestion_Click(object sender, EventArgs e)
		{
			if(EverythingIsNotNull())
			{
				if(!Directory.Exists("Added Questions"))
                {
					Directory.CreateDirectory("Added Questions");
                }
				if (Beginning.opt != 1)
				{
					if (File.Exists($"Added Questions\\{nameString.Text}.qst"))
					{
						MessageBox.Show($"Въпрос с името {nameString.Text} вече съществува.");
					}
					else
					{
						try
						{
							ReadFromControls().ExportToFile($"Added Questions\\{nameString.Text}.qst");
							MessageBox.Show("Въпросът беше създаден успешно");
						}
						catch(Exception ex)
						{
							if (File.Exists($"Added Questions\\{nameString.Text}.qst")) File.Delete($"Added Questions\\{nameString.Text}.qst");
							MessageBox.Show("Въпросът не можа да бъде създаден: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						ClearAll();
					}
				}
				else
				{
					if (File.Exists($"Added Questions\\{nameString.Text}.qst") && nameString.Text != ChooseName.name)
					{
						MessageBox.Show("Въпрос с името " + nameString.Text + " вече съществува.");
					}
					else
					{
						try
						{
							File.Delete($"Added Questions\\{ChooseName.name}.qst");
							ReadFromControls().ExportToFile($"Added Questions\\{nameString.Text}.qst");
							MessageBox.Show("Промените бяха запазени успешно");
						}
						catch (Exception ex)
						{
							if (File.Exists($"Added Questions\\{nameString.Text}.qst")) File.Delete($"Added Questions\\{nameString.Text}.qst");
							MessageBox.Show("Промените не можаха да бъдат запазени: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						this.Close();
						Beginning.alreadyOpened = true;
						new ChooseName().Show();
					}
				}
			}
			else
			{
				MessageBox.Show("Оставили сте празно поле");
			}
		}

		private void AddNewQuestion_FormClosed(object sender, FormClosedEventArgs e)
		{
			Beginning.alreadyOpened = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void picForQuestion_Click(object sender, EventArgs e)
		{
			if (defFileDial.ShowDialog() == DialogResult.OK)
			{
				try
				{
					picForQuestion.Image = ImageFromFile.ReadFromFile(defFileDial.FileName);
					if (Directory.Exists(defFileDial.FileName.Remove(defFileDial.FileName.LastIndexOf('\\')))) defFileDial.InitialDirectory = defFileDial.FileName.Remove(defFileDial.FileName.LastIndexOf('\\'));
				}
				catch (Exception)
				{
				}
			}
		}

		private void picOpt1_Click(object sender, EventArgs e)
		{
			if (defFileDial.ShowDialog() == DialogResult.OK)
			{
				try
				{
					picOpt1.Image = ImageFromFile.ReadFromFile(defFileDial.FileName);
				}
				catch (Exception)
				{
				}
			}
		}

		private void picOpt2_Click(object sender, EventArgs e)
		{
			if (defFileDial.ShowDialog() == DialogResult.OK)
			{
				try
				{
					picOpt2.Image = ImageFromFile.ReadFromFile(defFileDial.FileName);
				}
				catch (Exception)
				{
				}
			}
		}

		private void picOpt3_Click(object sender, EventArgs e)
		{
			if (defFileDial.ShowDialog() == DialogResult.OK)
			{
				try
				{
					picOpt3.Image = ImageFromFile.ReadFromFile(defFileDial.FileName);
				}
				catch (Exception)
				{
				}
			}
		}

		private void picOpt4_Click(object sender, EventArgs e)
		{
			if (defFileDial.ShowDialog() == DialogResult.OK)
			{
				try
				{
					picOpt4.Image = ImageFromFile.ReadFromFile(defFileDial.FileName);
				}
				catch (Exception)
				{
				}
			}
		}

		private void AddNewQuestion_Load(object sender, EventArgs e)
		{
			if (this.ClientSize.Width > this.panel1.Width) this.panel1.Left = (this.ClientSize.Width - this.panel1.Width) / 2;
			if (this.ClientSize.Height > this.panel1.Height) this.panel1.Top = (this.ClientSize.Height - this.panel1.Height) / 2;
			if (Beginning.opt == 1)
			{
				try
				{
					this.Text = "Редактиране на въпрос";
					nameString.Text = ChooseName.name;
					Question question = Question.ImportFromFile($"Added Questions\\{ChooseName.name}.qst");
					uslovie.Text = question.Condition;
					opcia1.Text = question.OptLabels[0];
					opcia2.Text = question.OptLabels[1];
					opcia3.Text = question.OptLabels[2];
					opcia4.Text = question.OptLabels[3];
					comboBox1.Text = question.Answer.ToString();
					picForQuestion.Image = question.ImageToQuest;
					picOpt1.Image = question.Options[0];
					picOpt2.Image = question.Options[1];
					picOpt3.Image = question.Options[2];
					picOpt4.Image = question.Options[3];
					this.Text = "Редактиране на въпрос";
					createQuestion.Text = "Запази промените";
				}
				catch(Exception ex)
				{
					MessageBox.Show("Въпросът не можа да бъде прочетен: " + ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

        private void AddNewQuestion_SizeChanged(object sender, EventArgs e)
        {
			if(this.ClientSize.Width > this.panel1.Width) this.panel1.Left = (this.ClientSize.Width - this.panel1.Width) / 2;
			if(this.ClientSize.Height > this.panel1.Height) this.panel1.Top = (this.ClientSize.Height - this.panel1.Height) / 2;
		}
    }
}
