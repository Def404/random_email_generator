// See https://aka.ms/new-console-template for more information

internal class Program
{
	public static void Main(string[] args)
	{

		if (args.Length < 4)
		{
			Console.WriteLine($"args < 4; ");
			Console.WriteLine($"name | surname | domain | count ");
			return;
		}
		var name = args[0];
		var surName = args[1];
		var domain = args[2];
		int count = 0;

		try
		{
			count = int.Parse(args[3]);	
		}
		catch (Exception e)
		{
			Console.WriteLine($"Error write count {args[3]}");
			return;
		}

		if (!domain.Contains("."))
		{
			Console.WriteLine($"is not domain {domain}");
			return;
		}

		if (count <= 0)
		{
			Console.WriteLine($"Count <= 0");
			return;
		}

		GeneratorEmail(name, surName, domain, count);
	}

	private static void GeneratorEmail(string name, string surname, string domain, int count)
	{
		var rand = new Random();
		
		name = name.ToLower();
		surname = surname.ToLower();
		domain = domain.ToLower();

		var resultEmail = "";
		
		for (int i = 0; i < count; i++)
		{
			resultEmail += GetRandomSymbol();
			resultEmail += name;
			resultEmail += GetRandomSymbol();
			resultEmail += surname;
			resultEmail += GetRandomSymbol();
			resultEmail += "@";
			resultEmail += domain;
			
			Console.WriteLine(resultEmail);
			resultEmail = "";
		}
	}

	private static string GetRandomSymbol()
	{
		string symbol = "/-_+=1234567890!?";
		var rand = new Random();

		var res = "";

		var countSymbol = rand.Next(0, 5);

		for (int i = 0; i < countSymbol; i++)
		{
			var index = rand.Next(symbol.Length);
			res += symbol[index];
		}
		
		return res;
	}
}