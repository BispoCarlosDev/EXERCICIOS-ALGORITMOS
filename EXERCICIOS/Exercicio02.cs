// Aqui adicionei as instruções para o usuário inserir os dados a serem coletados
// Repare que eu já declarei as variáves colocando as mesmas para receber o valor
// Eu também poderia ter feito a declaraçao delas anteriormente e apenas chamá-las nesse local
Console.WriteLine("Por favor, informe a medida do lado do quadrado em cm:");
double ladoquadrado = Convert.ToDouble(Console.ReadLine());

// Aqui é o local onde são processados os cálculos
double areaquadrado = ladoquadrado * ladoquadrado;
double perimetroquadrado = ladoquadrado * 4;

// Aqui é o local onde são exibidos os resultados dos cálculos
Console.WriteLine("\nA Área do Quadrado é: " + areaquadrado + " cm quadrados.");
Console.WriteLine("\nO Perímetro do Quadrado é: " + perimetroquadrado + " cm.");

// Obs. O \n é utilizado para criar uma quebra de linha