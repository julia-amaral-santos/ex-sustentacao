namespace Exercicios_Cesar;

public class Methods
{
    public void Sum(double num1, double num2)
    {
        double result = num1 + num2;
        Console.WriteLine(result);
    }

    public void CalculateOperations(double num1, double num2)
    {
        double sum = num1 + num2;
        double subtract = num1 - num2;
        double multiply = num1 * num2;
        double divide = num1 / num2;

        Console.WriteLine(
            $"{num1}+{num2} = {sum}\n" +
            $"{num1}-{num2} = {subtract}\n" +
            $"{num1}*{num2} = {multiply}\n" +
            $"{num1}/{num2} = {divide}");
    }


    public void CalculateFuelConsumption(double distance, double fuel)
    {
        double result = distance / fuel;
        Console.WriteLine($"O consumo médio de acordo com a distancia percorrida de {distance}Km usando {fuel}L de gasolina é de {result} Km/L.");
    }

    public void CalculateSalary()
    {
        double commissionPercentage = 0.15;

        string? name;
        double fixedSalary;
        double totalSales;

        Console.WriteLine("Nome: ");
        name = Console.ReadLine();

        Console.WriteLine("Salário fixo: ");
        fixedSalary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Total de vendas: ");
        totalSales = Convert.ToDouble(Console.ReadLine());


        double calculateComission = commissionPercentage * totalSales;
        double totalSalary = calculateComission + fixedSalary;
        decimal result = (decimal)totalSalary;
        Console.WriteLine($"{name}, o valor total que você vai receber é: R${result}.");
    }

    public void CalculateArithmeticMean()
    {
        string? name;
        double grade1;
        double grade2;
        double grade3;

        Console.WriteLine("Aluno, digite seu nome: ");
        name = Console.ReadLine();

        Console.WriteLine("Insira a primeira nota: ");
        grade1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira a segunda nota: ");
        grade2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira a terceira nota: ");
        grade3 = Convert.ToDouble(Console.ReadLine());

        double sumGrades = grade1 + grade2 + grade3;

        double result = Math.Round(sumGrades / 3, 1);

        Console.WriteLine($"{name}, sua média é: {result}");
    }

    public void SwapValue()
    {
        double a;
        double b;

        Console.WriteLine("Insira valor para A: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Insira valor para B: ");
        b = Convert.ToDouble(Console.ReadLine());

        double aux = a;
        a = b;
        b = aux;

        Console.WriteLine($"A agora possui o valor de B, que é: {a}");
        Console.WriteLine($"B agora possui o valor de A, que é: {b}");
    }
}

