Double metro, centimetro, km;

Console.Write("Entre com a medida (em metros): ");
metro = Convert.ToDouble(Console.ReadLine());

centimetro = metro * 100;
km = metro / 1000;

 Console.WriteLine("\n--- Equivalência ---");
  Console.WriteLine($"{centimetro} cm");
  Console.WriteLine($"{metro} m");
  Console.WriteLine($"{km} Km");