using System.Text.Json;

class Program
{
	static void Main(string[] args)
	{
		string opcion;
		bool salir = false;
		
		
		
		string rutaJson = Path.Combine(AppContext.BaseDirectory, "config.json");
		string contenidoJson = File.ReadAllText(rutaJson);
		using JsonDocument doc = JsonDocument.Parse(contenidoJson);
		JsonElement root = doc.RootElement;

		string empresa = root.GetProperty("empresa").GetString();
		string cif = root.GetProperty("cif").GetString();
		int iva = root.GetProperty("iva").GetInt32();
		string cadenaConexion = root.GetProperty("cadenaConexion").GetString();
		
		
		
		MenuPrincipal();
		opcion = Console.ReadLine();

		while (!salir)
		{
			switch (opcion)
			{
				case "1":
					MenuCliente();
					string opcion_MenuCliente = Console.ReadLine();

					while (!salir)
					{
						switch (opcion_MenuCliente)
						{
							case "1":
								Console.Clear();
								Console.BackgroundColor = ConsoleColor.Blue;
								
								Console.WriteLine("Alta de cliente.");
								Console.ResetColor();
								Console.WriteLine("Nombre......:");
								Console.WriteLine("Apellido......:");
								Console.WriteLine("Dirección.......:");
								Console.WriteLine("Telefono......:");
								Console.WriteLine("Mail......:");

								return;
								 
						}
					}
					
					
						
						
					return;
				case "2":
					MenuProductos();
					return;
				case "3":
					MenuFactura();
					return;
			}
		}
		


	}

	static void MenuCliente()
	{
		Console.Clear();
		
		Console.WriteLine("########");
		Console.WriteLine("Clientes");
		Console.WriteLine("########");
		Console.WriteLine("");
		Console.WriteLine("1) Alta de cliente.");
		Console.WriteLine("2) Modificar cliente.");
		Console.WriteLine("3) Eliminar Cliente.");
		Console.WriteLine("4) Listado de todos los clientes.");
		Console.WriteLine("5) Buscar cliente por ID.");
		Console.WriteLine("6) Facturas de cliente por ID de cliente.");
		Console.WriteLine("0) Volver al menú principal.");
		
		
		
		
	}

	static void MenuProductos()
	{
		Console.Clear();
		
		Console.WriteLine("#########");
		Console.WriteLine("Productos");
		Console.WriteLine("#########");
		Console.WriteLine("");
		Console.WriteLine("1) Alta de artículo.");
		Console.WriteLine("2) Modificar artículo.");
		Console.WriteLine("3) Eliminar artículo.");
		Console.WriteLine("4) Listado de todos los artículos.");
		Console.WriteLine("5) Buscar artículo por ID.");
		Console.WriteLine("6) Número total de artículos vendidos por ID de artículo.");
		Console.WriteLine("0) Volver al menú principal.");
		
	}

	static void MenuFactura()
	{
		Console.Clear();
		
		Console.WriteLine("########");
		Console.WriteLine("Facturas");
		Console.WriteLine("########");
		Console.WriteLine("");
		Console.WriteLine("1) Alta de factura.");
		Console.WriteLine("2) Modificar factura.");
		Console.WriteLine("3) Eliminar factura.");
		Console.WriteLine("4) Visualizar factura.");
		Console.WriteLine("0) Volver al menú principal.");
		
	}
	
	
	
	
	static void MenuPrincipal(string empresa, string cif)
	{
		
		Console.Clear();
		
		Console.WriteLine("##################################################");
		Console.WriteLine("#             SISTEMA DE FACTURACIÓN             #");
		Console.WriteLine("##################################################");
		Console.WriteLine("                                                  ");
		Console.WriteLine($"Empresa: {empresa}                               ");
		Console.WriteLine($"CIF: {cif}								     	 ");
		Console.WriteLine("													 ");
		Console.WriteLine("1) Clientes										 ");
		Console.WriteLine("2) Artículos										 ");
		Console.WriteLine("3) Facturas										 ");
		Console.WriteLine("0) Salir											 ");
		Console.WriteLine("													 ");
		Console.WriteLine("Opción:											 ");
		Console.WriteLine("													 ");
		Console.WriteLine("##################################################");
		Console.SetCursorPosition(8,12);
		
		
	}
	
	
	
	
	
}
    