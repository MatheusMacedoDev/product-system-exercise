using product_system_exercise;

introdution();

int option = 0;
while (option != 3) 
{
	Console.Clear();
	Console.WriteLine($"Digite uma das opções abaixo");
	Console.WriteLine($"1 - Cadastrar produto");
	Console.WriteLine($"2 - Listar produtos");
	Console.WriteLine($"3 - Sair");
	Console.Write($"=> ");
	
	option = int.Parse(Console.ReadLine());

	switch (option) 
	{
		case 1:
			Product.registerProduct();
			breakPoint();
			break;
		case 2:
			Product.listProducts();
			breakPoint();
			break;
		case 3:
			break;
		default:
			Console.WriteLine($"Opção inválida");
			breakPoint();
			break;
	}
}

static void introdution() 
{	
	Console.WriteLine($"---------------------------------------------");
	Console.WriteLine($"|                                           |");
	Console.WriteLine($"|           SUPER MERCADO MACEDO            |");
	Console.WriteLine($"|                                           |");
	Console.WriteLine($"---------------------------------------------");
	Console.WriteLine($"");
	breakPoint();
}

static void breakPoint() 
{
	Console.WriteLine($"");
	Console.WriteLine($"Precione qualquer botão para continuar...");
	Console.ReadKey();
	Console.Clear();
}

