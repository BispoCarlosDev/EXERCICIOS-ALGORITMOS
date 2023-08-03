// Aqui adicionei as instruções para o usuário inserir os dados a serem coletados
// Repare que eu já declarei as variáves colocando as mesmas para receber o valor
// Eu também poderia ter feito a declaraçao delas anteriormente e apenas chamá-las nesse local
Console.WriteLine("Por favor, informe a medida do raio do círculo em cm:");
double raiocirculo = Convert.ToDouble(Console.ReadLine());

// Aqui é o local onde são processados os cálculos
double areacirculo = 3.14 * (raiocirculo * raiocirculo);
double perimetrocirculo = 2 * 3.14 * raiocirculo;

// Aqui é o local onde são exibidos os resultados dos cálculos
Console.WriteLine("\nA Área do Círculo é: " + areacirculo + " cm quadrados.");
Console.WriteLine("\nO Perímetro do Círculo é: " + perimetrocirculo + " cm.");

// Obs. O \n é utilizado para criar uma quebra de linha