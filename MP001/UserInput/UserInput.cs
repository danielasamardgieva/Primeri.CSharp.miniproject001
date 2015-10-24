using System;

namespace UserInput
{
	public class UInput
	{
		Colors.ForCLI _c = new Colors.ForCLI ();
		About.Me about=new About.Me();
		public UInput ()
		{
		}
		public void sayHello()
		{
			Console.Write ("Добре дошли в " + about.shortName + "\n" + about.version + "\n");
		}
    	public void getUserCommands()
		{
           string _command="";

	       do
			//Взимане на команда
			{
				_c.Prompt();   Console.Write("$ ");
				_c.Command(); _command=Console.ReadLine();

			//Проверка за налични команди
				if (_command.ToLower().Contains("команда1")) 
				{
					_c.Default(); Console.Write("Стартирана е ");
					_c.Result();  Console.WriteLine("Команда1 \n");
				}
				if (_command.ToLower().Contains("команда2")) 
				{
					_c.Default(); Console.Write("Стартирана е ");
					_c.Result();  Console.WriteLine("Команда2 \n");
				}
				if (_command.ToLower().Contains("команда3"))

				{
					_c.Default(); Console.Write("Стартирана е ");
					_c.Result();  Console.WriteLine("Команда3 \n");
				}


			}while(_command != "изход");
		}
			

			public void justTesting()
		{
			Console.WriteLine("Стартиране на UserInput.Uinput.justTesting()");
		}
	}
}

