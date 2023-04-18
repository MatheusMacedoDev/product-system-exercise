using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace product_system_exercise
{
	public class Product
	{
		private static LinkedList<Product> productList = new LinkedList<Product>();

		private string name;
		private decimal price;
		private bool onPromotion;

		public Product(string name, decimal price, bool onPromotion)
		{
			this.name = name;
			this.price = price;
			this.onPromotion = onPromotion;
		}

		public static void registerProduct()
		{
			Product product;
			string productName;
			decimal productPrice;
			bool productOnPromotion;
			
			Console.Clear();
			Console.WriteLine($"---------------------------------------------");
			Console.WriteLine($"|             Cadastrar Produto             |");
			Console.WriteLine($"---------------------------------------------");
			Console.WriteLine($"");

			Console.Write($"Digite o nome: ");
			productName = Console.ReadLine();

			Console.Write($"Digite o preço: ");
			productPrice = decimal.Parse(Console.ReadLine());

			Console.Write($"O produto está em promoção (S/N): ");
			productOnPromotion = Console.ReadLine().ToLower() == "s";

			product = new Product(productName, productPrice, productOnPromotion);

			productList.AddLast(product);
			
			Console.Clear();
			Console.WriteLine($"Produto adicionado com sucesso!");
		}
		
		public static void listProducts() 
		{
			Console.Clear();
			Console.WriteLine($"---------------------------------------------");
			Console.WriteLine($"|             Lista de Produtos             |");
			Console.WriteLine($"---------------------------------------------");
			Console.WriteLine($"");
			
			int showIndex = 1;
			foreach(var product in productList) 
			{
				Console.WriteLine($"{showIndex} - {product.ToString()}");
				showIndex++;
			}
		}
		
		private string ToString() 
		{
			string promotionText = onPromotion ? "Está de promoção" : "Não está de promoção";
			return $"Nome: {this.name} - Preço: {this.price.ToString("C", new CultureInfo("pt-BR"))} - {promotionText}";
		}
	}
	
}