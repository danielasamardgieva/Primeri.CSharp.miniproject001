﻿using System;

namespace UserInput
{
	
	public class UInput
	{
		About.Me about=new About.Me ();
		Colors.ForCLI _c=new Colors.ForCLI ();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary();

			public UInput ()
		{
		}

		public void sayHello ()
		{
		Console.WriteLine ("Добре дошли в " + about.shortName + "\n" + about.version + "\n");
		}
		public void getUserCommands ()
		{
			string _command = " ";

			do {
				//Взимане на команда
				_c.Prompt ();  Console.Write ("$");
				_c.Command ();_command=Console.ReadLine ();

				//проверка за наличните команди
				if (_command.ToLower().Contains("яма"))		 _calc.F01.calc(_command);
				if (_command.ToLower().Contains("въгъл"))	 _calc.F02.calc(_command);
				if (_command.ToLower().Contains("иъгъл")) 	 _calc.F03.calc(_command);
		
				
		} while (_command.ToLower () != "изход");
		}
				
		public void justTesting()
		{
			Console.WriteLine("Стартиране на UserIput.UInput.justTesting ()");
		}

	}
}

