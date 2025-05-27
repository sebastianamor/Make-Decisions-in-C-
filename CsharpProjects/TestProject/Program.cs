
Random random = new Random();

int resultadoNum = random.Next(0, 2) == 0 ? 50 : 100;
string caraOSello = resultadoNum == 50 ? "Cara" : "Sello";

Console.WriteLine($"Dice: {caraOSello}");
