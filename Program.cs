using desafio_final_trilha_net_tests.models;

Calculadora calc = new Calculadora();
calc.Somar(5,3);
calc.Multiplicar(5,3);
calc.Subtrair(3,5);
List<string> temp = calc.Historico();


foreach (var item in temp)
    {
        Console.WriteLine(item);
    }