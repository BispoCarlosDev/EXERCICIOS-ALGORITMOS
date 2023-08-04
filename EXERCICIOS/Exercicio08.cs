// Aqui adicionei as instruções para o usuário inserir os dados a serem coletados
// Repare que eu já declarei as variáves colocando as mesmas para receber o valor
// Eu também poderia ter feito a declaraçao delas anteriormente e apenas chamá-las nesse local
Console.WriteLine("Por favor, informe a temperatura em Fahrenheit:");
double fahrenheit = Convert.ToDouble(Console.ReadLine());

// Aqui é o local onde são processados os cálculos
double celsius = (fahrenheit - 32) * 5/9;

// Aqui é o local onde são exibidos os resultados dos cálculos
Console.WriteLine("\nA temperatura informada em Graus Celsius equivale a: " + celsius + " C.");

// Obs. O \n é utilizado para criar uma quebra de linha
