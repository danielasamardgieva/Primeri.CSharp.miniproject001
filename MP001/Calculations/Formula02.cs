﻿using System;

namespace Calculations
{
	/// <summary>
	/// Формула за изчисляване обем на изкоп с вдлъбнат ъгъл - Formula02 </summary>
	public class Formula02
	{
		Colors.ForCLI _cl=new Colors.ForCLI();


		public Formula02 ()
		{
		}

		/// <summary>
		///Метод за пресмятане на Formula02 </summary>
		/// <param name="_input" >Това е цялата команда с параметри, въведени от потребителя</param>
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
						_cl.Default();	Console.Write ("Обемът на вдлъбнатия ъгъл е: ");
						_cl.Result();	Console.Write (result.ToString ("N2"));
						_cl.Default();	Console.WriteLine (" m3 \n");

					} else{
						_cl.Default();	Console.WriteLine ("Има грешно въведени параметрил\n С параметъра '-п' можете да видите синтаксиса на командата.\n");
					}
				}

			} catch {

			}
		}
		/// <summary>
		/// Вътрешен метод за пресмятане на Formula02 след парсване на командата от потребителя </param>
		/// /// <param name="_param" >Това е масив от стрингове, който съдържа командата с парснати параметри, въведени от потребителя</param>
		/// /// <param name="_result" >Това е променлива, която връща резултата от изчисление на формулата</param>
		private bool runCalculate (String[] _param, out double _result)
		{
			try {
				double a = 0;
				Double.TryParse (_param [1], out a);
				double b = 0;
				Double.TryParse (_param [2], out b);
				double h = 0;
				Double.TryParse (_param [3], out h);

				_result = a * b * h / 3;
				return true;
			} catch {
			}
			_result = 0;
			return false;
		}
		/// <summary>
		/// Помощ за проверка на синтаксиса </summary>
		private void help ()
		{
			_cl.Result ();	Console.Write ("[въгъл]");
			_cl.Default ();	Console.WriteLine (" - вдлъбнат ъгъл");

			_cl.Command (); Console.Write ("параметри:");
			_cl.Default ();	Console.WriteLine (" a b  и h \n");

			_cl.Command ();	Console.Write (" a и b");
			_cl.Default ();	Console.WriteLine (" - ширина и дължина");

			_cl.Command ();	Console.Write (" h ");
			_cl.Default ();	Console.WriteLine (" - височина");

		}

	}

}

