using System;

namespace Calculator001
{
	/// <summary>
	/// Главна библиотека на програмата - Main class </summary>
	class MainClass
	{
		/// <summary>
		/// Дефиниране на библиотеки </summary>
		public UserInput.UInput uInput=new UserInput.UInput();
		public About.Me about= new About.Me();

		public static void Main (string[] args)
		{
			MainClass _program = new MainClass ();

		//Форматиране на програматd
			Console.Title= _program.about.shortName+ ", "+ _program.about.version;

		//Стартиране на програмата
			_program.uInput.sayHello();
			_program.uInput.getUserCommands ();
		}
	}
}
