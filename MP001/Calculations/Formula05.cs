using System;

namespace Calculations
{
	public class Formula05
	{
		Colors.ForCLI _cl=new Colors.ForCLI();

		public Formula05 ()
		{
		}
		//Формула05 изчислява обем на канален изкоп 
		public void calc (string _input)
		{
			try {
				string[] param = _input.Split (' ');

				if (param.Length > 1 && _input.ToLower().Contains("-п"))
				{
					help ();
				}

				if (param.Length > 1 && !_input.ToLower().Contains("-п"))
				{
					double result = 0;

					if (runCalculate (param, out result)) 
					{
						_cl.Default();	Console.Write ("Обемът на каналния изкоп е: ");
						_cl.Result();	Console.Write (result.ToString ("N2"));
						_cl.Default();	Console.WriteLine (" m3 \n");

					} else{
						_cl.Default();	Console.WriteLine ("Има грешно въведени параметрил\n С параметъра '-п' можете да видите синтаксиса на командата.\n");
					}
				}

			} catch {

			}
		}
		private bool runCalculate (String[] _param, out double _result)
		{
			try {
				double a = 0;
				Double.TryParse (_param [1], out a);

				double b = 0;
				Double.TryParse (_param [2], out b);

				double h = 0;
				Double.TryParse (_param [3], out h);

				double l = 0;
				Double.TryParse (_param [4], out l);

				_result = (a+b)/ 2*h*l;

				return true;
			} catch {
			}
			_result = 0;
			return false;
		}

		private void help ()
		{
			_cl.Result ();	Console.Write ("[канал]");
			_cl.Default ();	Console.WriteLine (" - канален изкоп");

			_cl.Command (); Console.Write ("параметри:");
			_cl.Default ();	Console.WriteLine (" a, b, h и l \n");

			_cl.Command ();	Console.Write (" a ");
			_cl.Default ();	Console.WriteLine (" - горна ширина на профила");

			_cl.Command ();	Console.Write (" b ");
			_cl.Default ();	Console.WriteLine (" - долна ширина на профила");

			_cl.Command ();	Console.Write (" h ");
			_cl.Default ();	Console.WriteLine (" - височина на профила");

			_cl.Command ();	Console.Write (" l ");
			_cl.Default ();	Console.WriteLine (" - дължина на профила");

		}
	}
}


