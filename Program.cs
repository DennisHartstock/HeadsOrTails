Random random = new();
int result = random.Next(1, 7);
Console.WriteLine($"{result} - {(result > 3 ? "Heads" : "Tails")}");
