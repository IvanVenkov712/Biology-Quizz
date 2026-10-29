using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Biology_quizz
{
	[Serializable]
	public class Question
	{
		private int answer = 0;
		private string condition = "";
		private Image imageToQuest = null;
		private Image[] options = new Bitmap[4];
		private string[] optLabels = new string[4];

		public int Answer
		{
			get
			{
				return this.answer;
			}
			set
			{
				this.answer = value;
			}
		}
		public string Condition
		{
			get
			{
				return this.condition;
			}
			set
			{
				this.condition = value;
			}
		}
		public Image ImageToQuest
		{
			get
			{
				return this.imageToQuest;
			}
			set
			{
				this.imageToQuest = value;
			}
		}
		public Image[] Options
		{
			get
			{
				return this.options;
			}
			set
			{
				this.options = value;
			}
		}
		public string[] OptLabels
		{
			get
			{
				return this.optLabels;
			}
			set
			{
				this.optLabels = value;
			}
		}

		public static Question ImportFromDirectory(string path)
		{
			Question res = new Question();
			string[] lines = File.ReadAllLines(path + "\\" + "QuestStrings.txt");
			res.Condition = lines[0];
			res.OptLabels[0] = lines[1];
			res.OptLabels[1] = lines[2];
			res.OptLabels[2] = lines[3];
			res.OptLabels[3] = lines[4];
			res.Answer = int.Parse(lines[5]);
			res.ImageToQuest = ImageFromFile.ReadFromFile(path + "\\" + "PicForQuestion.png");
			res.Options[0] = ImageFromFile.ReadFromFile(path + "\\" + "Opt1Pic.png");
			res.Options[1] = ImageFromFile.ReadFromFile(path + "\\" + "Opt2Pic.png");
			res.Options[2] = ImageFromFile.ReadFromFile(path + "\\" + "Opt3Pic.png");
			res.Options[3] = ImageFromFile.ReadFromFile(path + "\\" + "Opt4Pic.png");
			return res;
		}
		public static Question ImportFromFile(string fileName)
		{
			using(FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				return (Question)formatter.Deserialize(stream);
			}
		}
		public void ExportToFile(string fileName)
		{
			using (FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
			{				
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(stream, this);
			}
		}
		public void ExportToDirectory(string path)
		{
			Directory.CreateDirectory(path);
			ImageFromFile.SaveToFile(new Bitmap(this.ImageToQuest), path + "\\PicForQuestion.png", ImageFormat.Png);
			ImageFromFile.SaveToFile(new Bitmap(this.Options[0]), path + "\\Opt1Pic.png", ImageFormat.Png);
			ImageFromFile.SaveToFile(new Bitmap(this.Options[1]), path + "\\Opt2Pic.png", ImageFormat.Png);
			ImageFromFile.SaveToFile(new Bitmap(this.Options[2]), path + "\\Opt3Pic.png", ImageFormat.Png);
			ImageFromFile.SaveToFile(new Bitmap(this.Options[3]), path + "\\Opt4Pic.png", ImageFormat.Png);

			using(StreamWriter wr = new StreamWriter(path + "\\QuestStrings.txt"))
			{
				wr.WriteLine(Condition);
				for(int i = 0; i < this.OptLabels.Length; i++)
				{
					wr.WriteLine(this.OptLabels[i]);
				}
				wr.WriteLine(this.Answer);
			}
		}
	}
}
