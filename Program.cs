namespace CalculadoraFracao

{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numerador da primeira fração:");
            int numerador1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("agora digite seu denominador:");
            int denominador1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numerador da primeira fração:");
            int numerador2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("agora digite o denominador:");
            int denominador2 = Convert.ToInt32(Console.ReadLine());
            Fracao f1 = new Fracao(numerador1,denominador1);
            Fracao f2 = new Fracao(numerador2,denominador2);
            Console.WriteLine("agora escolha a operação digitando o número correspondente:");
            Console.WriteLine("0- Soma");
            Console.WriteLine("1- Substrair");
            Console.WriteLine("2- Divisão");
            Console.WriteLine("3- Multiplicação");

            int operacao = Convert.ToInt32(Console.ReadLine());
            Fracao resu= new Fracao(1,1); 
            
            switch (operacao)
            {
                case 0:
                 resu=Calculadora.Somar(f1, f2);
                    break;
                case 1:
                    resu=Calculadora.Subtrair(f1, f2);
                    break;
                case 2:
                    resu=Calculadora.Divisao(f1, f2);
                    break;
                case 3:
                    resu=Calculadora.Multiplicacao(f1, f2);
                    break;
            }
            
            Console.WriteLine($"O resultado desta operação é: {resu}");
        }
    }
}
