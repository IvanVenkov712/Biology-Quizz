using System.IO;
using System.Linq;

namespace Biology_quizz
{
	public static class Questing
	{
		public static string[] GetQuestNames()
		{
			return Directory.GetFiles("Added Questions").Select(s =>
			{
				int ind = s.LastIndexOf("\\") + 1;
				return s.Substring(ind, s.Length - ind - 4);
			}).ToArray();
		}
	}
}
