// Aqui adicionei as instruções para o usuário inserir os dados a serem coletados
// Repare que eu já declarei as variáves colocando as mesmas para receber o valor
// Eu também poderia ter feito a declaraçao delas anteriormente e apenas chamá-las nesse local
Console.WriteLine("Por favor, informe o primeiro número para realizar a divisão:");
int primeiro = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nPor favor, informe o segundo número para realizar a divisão:");
int segundo = Convert.ToInt32(Console.ReadLine());

// Aqui é o local onde são processados os cálculos
int quociente = primeiro / segundo;
int resto = primeiro % segundo;

// Aqui é o local onde são exibidos os resultados dos cálculos
Console.WriteLine("\nO quociente da divisão é: " + quociente + ".");
Console.WriteLine("\nO resto da divisão é: " + resto + ".");

// Obs. O \n é utilizado para criar uma quebra de linha
