Console.WriteLine("Digite a forma geometrica: quadrado (1), triangulo (2) ou circulo (3)");
string inpt = Console.ReadLine().ToLower();
while (inpt != "quadrado" "1" && inpt != "triangulo"  && inpt != "circulo" && inpt != "1" && inpt != "2" && inpt != "3"  )
{
    Console.WriteLine("forma inválida");
    Console.WriteLine("Digite a forma geometrica: quadrado, triangulo ou circulo");
    inpt = Console.ReadLine().ToLower();
}
double area = 0;
double baseValue = 0;
double height = 0;
switch (inpt)
{
    case "quadrado":
    case "1":
        Console.WriteLine("Digite o valor da base:");
        baseValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura:");
        height = Convert.ToDouble(Console.ReadLine());
        area = baseValue * height;
        break;
    case "triangulo": 
    case "2":
        Console.WriteLine("Digite o valor da base:");
         baseValue = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura:");
         height = Convert.ToDouble(Console.ReadLine());
        area = (baseValue * height) / 2;
        break;
    case "circulo":
    case "3":
        Console.WriteLine("Digite o valor do raio:");
        double radius = Convert.ToDouble(Console.ReadLine());
        area = Math.PI * Math.Pow(radius, 2);
        break;
}
Console.WriteLine($"Área do {inpt} é de {area}².");