internal class Program
{
	private static void Main(string[] args)
	{
		Console.WriteLine("Por favor, ingresa tu fecha de nacimiento (yyyy/mm/dd):");
		string input = Console.ReadLine();

		if (DateTime.TryParse(input, out DateTime fechaNacimiento))
		{
			string diaSemana = fechaNacimiento.DayOfWeek.ToString();
			Console.WriteLine($"Naciste un {diaSemana}.");
		}
		else
		{
			Console.WriteLine("Formato de fecha incorrecto. Por favor, utiliza el formato yyyy/mm/dd.");
		}
	}
}