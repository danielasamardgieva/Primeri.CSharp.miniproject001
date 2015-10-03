using System;

namespace UserInput
{
	public class UInput
	{
		public UInput ()
		{
		}

		public void getUserCommands ()
		{
			string _command = "";

			do {
				Console.Write ("$");
				_command=Console.ReadLine ();

				//проверка за наличните команди
				if (_command.ToLower().Contains("команда1")) Console.WriteLine("Стартирана е команда 1 \n");
				if (_command.ToLower().Contains("команда2")) Console.WriteLine("Стартирана е команда 2 \n");
				if (_command.ToLower().Contains("команда3")) Console.WriteLine("Стартирана е команда 3 \n");

			} while (_command.ToLower () != "изход");
		}
		public void justTesting()
		{
			Console.WriteLine("Стартиране на UserIput.UInput.justTesting ()");
		}

	}
}

