using System;

namespace Colors
{
	/// <summary>
	/// Клас за форматиране на изходните данни (с цветове) For CLI </summary>
	public class ForCLI
	{
		public ForCLI ()
		{
		}
		public void Default ()
		{
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		public void Prompt()
		{
			Console.ForegroundColor = ConsoleColor.Green;
		}
		
		public void Command()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
		}

		public void Result()
		{
			Console.ForegroundColor = ConsoleColor.White;
		}

	}
}

