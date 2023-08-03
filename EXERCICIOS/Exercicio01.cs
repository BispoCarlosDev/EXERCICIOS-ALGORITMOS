// Aqui adicionei as instruções para o usuário inserir os dados a serem coletados
// Repare que eu já declarei as variáves colocando as mesmas para receber o valor
// Eu também poderia ter feito a declaraçao delas anteriormente e apenas chamá-las nesse local
Console.WriteLine("Por favor, informe a medida da base do retângulo em cm:");
double baseretangulo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nPor favor, informe a medida da altura do retângulo em cm:");
double alturaretangulo = Convert.ToDouble(Console.ReadLine());

// Aqui é o local onde são processados os cálculos
double arearetangulo = baseretangulo * alturaretangulo;
double perimetroretangulo = (baseretangulo + alturaretangulo) * 2;

// Aqui é o local onde são exibidos os resultados dos cálculos
Console.WriteLine("\nA Área do Retângulo é: " + arearetangulo + " cm quadrados.");
Console.WriteLine("\nO Perímetro do Retângulo é: " + perimetroretangulo + " cm.");

// Obs. O \n é utilizado para criar uma quebra de linha