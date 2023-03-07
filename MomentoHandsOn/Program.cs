namespace MomentoHandsOn
{
	internal class Program
	{
		/*1. Elabore um programa com uma função que solicita a digitação de uma temperatura em graus Celsius
		 * e exiba a temperatura convertida em graus Fahrenheit, utilizando a fórmula (onde C é a temperatura em Celsius)
		 * F = C x 1,8 + 32
		 * 
		 * 2. Elabore um programa com uma função que solicita a digitação de dois números, sendo o primeiro a base e 
		 * o segundo o expoente. Faça o cálculo e exiba o resultado. 3² = 3 * 3 | 2³ = 2 * 2 * 2
		 */
		public static double tc; //variável global
		public static double b;
		public static double expoente;
		public static void lerTemperatura()
		{
			Console.WriteLine("Digite uma temperatura em ºC: ");
			tc = Convert.ToDouble(Console.ReadLine());
		}

		public static void conversaoTemperatura()
		{
			double tf = tc * 1.8 + 32;
			Console.WriteLine(tc + "ºC = " + tf + "ºF");
		}

		public static void lerValores()
		{
			Console.WriteLine("Digite o valor da base: ");
			b = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite o valor do expoente: ");
			expoente = Convert.ToDouble(Console.ReadLine());
		}

		public static void calcular()
		{
			double resultado = 1;
			for (int i = 1; i <= expoente; i++) {
				resultado = resultado * b; //resultado *= b;
			}
			Console.WriteLine("Resultado = " + resultado);
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Momento HandsOn");
			Console.WriteLine("Digite 1 para conversão de temperatura.\n2 para expoente: ");
			int op = Convert.ToInt32(Console.ReadLine());
			if(op == 1) {
				lerTemperatura();
				conversaoTemperatura();
			}
			else
			{
				lerValores();
				calcular();
			}
			
		}
	}
}