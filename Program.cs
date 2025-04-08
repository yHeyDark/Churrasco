int crianca, adultos, adultosBebem;

// dados pre-estabelecidos
double carneAdulto = 400; //Gramas 
double carneCrianca = 200;

double acompAdulto = 200;
double acompCrianca = 200;

double cerveja = 2000; //ml
double refriPorPessoa = 500; //ml
double aguaPorPessoa = 400; //ml

// programa
Console.WriteLine("--- Churrasco ---");
Console.Write("Digite Adultos (que consomem bebidas alcoólicas): ");
adultosBebem = int.Parse(Console.ReadLine()!);

Console.Write("Digite o restante dos adultos: ");
adultos = int.Parse(Console.ReadLine()!);

Console.Write("Digite a quantidade de crianças: ");
crianca = int.Parse(Console.ReadLine()!);

// total 
double ttlCarne = (adultosBebem + adultos) * carneAdulto + crianca * carneCrianca;
double ttlAcomp = (adultosBebem + adultos) * acompAdulto + crianca * acompCrianca;
double ttlCerveja = adultosBebem * cerveja;
double ttlRefri = (adultosBebem + adultos + crianca) * refriPorPessoa;
double ttlAgua = (adultos + adultosBebem + crianca) * aguaPorPessoa;

// conversão
double carneKg = ttlCarne / 1000;
double acompKg = ttlAcomp / 1000;
double cervejaL = ttlCerveja / 1000;
double aguaL = ttlAgua / 1000;
double refriL = ttlRefri / 1000;

// resultado Tabela
Console.WriteLine("\n--- Resultado ---");
Console.WriteLine($"Carne.............: {carneKg}kg");
Console.WriteLine($"Acompanhamentos...: {acompKg}kg");
Console.WriteLine($"Cerveja...........: {cervejaL}L");
Console.WriteLine($"Refrigerante......: {refriL}L");
Console.WriteLine($"Água..............: {aguaL}L");
