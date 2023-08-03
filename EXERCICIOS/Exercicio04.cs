// Aqui adicionei as instruções para o usuário inserir os dados a serem coletados
// Repare que eu já declarei as variáves colocando as mesmas para receber o valor
// Eu também poderia ter feito a declaraçao delas anteriormente e apenas chamá-las nesse local
Console.WriteLine("Por favor, informe a medida do primeiro lado do triangulo em cm:");
double lado01 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nPor favor, informe a medida do segundo lado do triangulo em cm:");
double lado02 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nPor favor, informe a medida do terceiro lado do triangulo em cm:");
double lado03 = Convert.ToDouble(Console.ReadLine());

// Aqui é o local onde são processados os cálculos
double perimetrotriangulo = lado01 + lado02 + lado03;

// Aqui é o local onde são exibidos os resultados dos cálculos
Console.WriteLine("\nO Perímetro do Triângulo é: " + perimetrotriangulo + " cm.");

// Obs. O \n é utilizado para criar uma quebra de linha