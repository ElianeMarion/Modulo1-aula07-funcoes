namespace FuncaoComRetorno
{
	internal class Program
	{
		//retorno: int, double, string
		public static double calcularReajuste(double sal)
		{
			double novoSal = sal * 1.1; //10% + sal
			return novoSal;
		}
		static void Main(string[] args)
		{
			double salario, novoSalario;

			Console.WriteLine("Reajuste Salarial");
			Console.WriteLine("Digite o salário atual: ");
			salario = Convert.ToDouble(Console.ReadLine());
			novoSalario = calcularReajuste(salario);
			Console.WriteLine("Seu novo salário: R$ " + novoSalario);

			Console.WriteLine("Seu novo salário: R$ " + calcularReajuste(salario));
		}
	}
}