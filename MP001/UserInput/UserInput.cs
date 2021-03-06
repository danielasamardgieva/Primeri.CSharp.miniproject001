﻿using System;

namespace UserInput
{
	/// <summary>
	/// Клас за управление на входните и изходните параметри - U input </summary>
	public class UInput
	{
		About.Me about=new About.Me();
		Colors.ForCLI _c = new Colors.ForCLI ();
		Calculations.MainLibrary _calc=new Calculations.MainLibrary();

		/// <summary>
		///Метод за управление на входните параметри </summary>
		public UInput ()
		{
		}
		/// <summary>
		/// Метод за приветствие на потребителя </summary>
		public void sayHello()
		{
			Console.Write ("Добре дошли в " + about.shortName + "\n" + about.version + "\n");
		}
		/// <summary>
		/// Метод  за взимане на команда от потребителя </summary>
    	public void getUserCommands()
		{
           string _command="";

	       do
			//Взимане на команда
			{
				_c.Prompt();   Console.Write("$ ");
				_c.Command(); _command=Console.ReadLine();

			//Проверка за налични команди
				if (_command.ToLower().Contains("яма"))    								 _calc.F01.calc(_command);

				if (_command.ToLower().Contains("въгъл"))  								 _calc.F02.calc(_command);


				if (_command.ToLower().Contains("иъгъл"))  								 _calc.F03.calc(_command);

				if (_command.ToLower().Contains("стръгъл"))  							 _calc.F04.calc(_command);

				if (_command.ToLower().Contains("канал"))  							    _calc.F05.calc(_command);

				if (_command.ToLower().Contains("помощ") || _command.ToLower() =="-п")   _calc.commands ();

				if (_command.ToLower()==("изчисти") || _command.ToLower() =="и")  
				{
					Console.Clear ();
					_c.Default ();
					Console.Write ("Добре дошли в " + about.shortName + "\n" + about.version + "\n");
				}
			}while(_command != "изход");
		}
			
		/// <summary>
		/// Проверка </summary>
			public void justTesting()
		{
			Console.WriteLine("Стартиране на UserInput.Uinput.justTesting()");
		}
	}
}

