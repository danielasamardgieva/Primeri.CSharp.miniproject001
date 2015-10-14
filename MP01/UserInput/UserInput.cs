using System;

namespace UserInput
{
	
	public class UInput
	{
		About.Me about=new About.Me ();
		Colors.ForCLI _c=new Colors.ForCLI ();
		Calculations.MainLibrary _calc=new Calculations.MainLibrary ();
		public UInput ()
		{
		}
		public void sayHello ()
		{
		Console.WriteLine ("Добре дошли в " + about.shortName + "\n" + about.version + "\n");
		}
		public void getUserCommands ()
		{
			string _command = "";

			do {
				//Взимане на команда
				_c.Prompt ();  Console.Write ("$");
				_c.Command ();_command=Console.ReadLine ();

				//проверка за наличните команди
				if (_command.ToLower().Contains("яма")) _calc.F01.calc(_command);
				{
				//	_c.Default(); Console.WriteLine("Стартирана е ");
				//	_c.Result (); Console.WriteLine("Команда 1 ");
				}
				if (_command.ToLower().Contains("команда2"))
				{
					_c.Default (); Console.WriteLine("Стартирана е ");
					_c.Result (); Console.WriteLine("команда 2 ");
				}
				if (_command.ToLower().Contains("команда3")) 
				{
					_c.Default (); Console.WriteLine("Стартирана е ");
					_c.Result (); Console.WriteLine("команда 3");
				}
				} while (_command.ToLower () != "изход");
		}
		public void justTesting()
		{
			Console.WriteLine("Стартиране на UserIput.UInput.justTesting ()");
		}

	}
}

