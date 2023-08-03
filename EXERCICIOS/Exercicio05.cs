// Aqui adicionei as instruções para o usuário inserir os dados a serem coletados
// Repare que eu já declarei as variáves colocando as mesmas para receber o valor
// Eu também poderia ter feito a declaraçao delas anteriormente e apenas chamá-las nesse local
Console.WriteLine("Por favor, informe um número inteiro para a leitura:");
int numero = Convert.ToInt32(Console.ReadLine());

// Aqui é o local onde são processados os cálculos
int sucessor = numero + 1;

// Aqui é o local onde são exibidos os resultados dos cálculos
Console.WriteLine("\nO número sucessor de " + numero + " é: " + sucessor + ".");

// Obs. O \n é utilizado para criar uma quebra de linha