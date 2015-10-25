using System;

namespace Calculations
{
	/// <summary>
	/// Клас за формула, с която се изчислява обем на изкоп със страничен ъгъл - Formula04 </summary>
	public class Formula04
	{
		Colors.ForCLI _cl=new Colors.ForCLI();
			
		public Formula04 ()
			{
			
			}
			//Формула04 изчислява обем изкоп = на страничен ъгъл
			public void calc (string _input)
			{
				try {
					string[] param = _input.Split (' ');

					if (param.Length > 1 && _input.ToLower().Contains("-п"))
					{
						help ();
					}

					if (param.Length == 4) {
						double result = 0;

						if (runCalculate (param, out result)) 
						{
							_cl.Default();	Console.Write ("Обемът на страничния ъгъл е: ");
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
					
					double h = 0;
					Double.TryParse (_param [2], out h);

					double l = 0;
					Double.TryParse (_param [3], out l);

					_result = (a * h / 2)*l;
					return true;
				} catch {
				}
				_result = 0;
				return false;
			}

			private void help ()
			{
				_cl.Result ();	Console.Write ("[стръгъл]");
				_cl.Default ();	Console.WriteLine (" - страничен ъгъл");

				_cl.Command (); Console.Write ("параметри:");
				_cl.Default ();	Console.WriteLine (" a  h и l \n");

				_cl.Command ();	Console.Write (" a ");
				_cl.Default ();	Console.WriteLine (" - ширина на профила");

				_cl.Command ();	Console.Write (" h ");
				_cl.Default ();	Console.WriteLine (" - височина на профила");

				_cl.Command ();	Console.Write (" l ");
				_cl.Default ();	Console.WriteLine (" - дължина на профила");
				
			}
		}
	}


