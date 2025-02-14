using System.Globalization;

System.Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

List<TaxPayer> list = new List<TaxPayer>();

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Individual or company (i/c)? ");
    char type = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    String name = Console.ReadLine();

    Console.Write("Anual income: ");
<<<<<<< HEAD
    double income = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
=======
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
>>>>>>> 29f5461 (Feito uma função que se o usuário não digitar corretamente, ele pede novamente)
    
    if (type == 'i') {
        System.Console.Write("Health expenditures: ");
        double health = double.Parse(Console.ReadLine());
        list.Add(new Individual(name, income, health));
    } else {
        System.Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());
        list.Add(new Company(name, income, employees));
    }

}

System.Console.WriteLine();
System.Console.WriteLine("TAXES PAID:");

double sum = 0;
foreach (TaxPayer obj in list)
{
    double tax = obj.Tax();
    System.Console.WriteLine(obj.Name + ": $ " + tax.ToString("F2"), CultureInfo.InvariantCulture);
    sum = sum + tax;
    
}
 Console.WriteLine();
 Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));