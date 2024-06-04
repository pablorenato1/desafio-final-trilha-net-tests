# Trilha .NET - Trabalhando com Desenvolvimento Orientado a Testes (DIO)

## Sobre o Desafio
Este desafio tem como objetivo criar um projeto de console em C# utilizando .NET 6, que realiza operações matemáticas básicas (soma, subtração, multiplicação e divisão). Além disso, você deve aplicar testes unitários utilizando xUnit para garantir a funcionalidade correta e a ausência de erros no programa. A aplicação do TDD (Desenvolvimento Orientado por Testes) é uma prática fundamental neste desafio.

# Pré-requisitos
- Ter o .NET instalado, neste desafio foi utilizado o mais recente até então, o .NET 8.0

## Como executar o projeto
1. Clone este repositório em sua máquina local.
2. Abra um terminal ou prompt de comando.
3. Navegue até o diretório `desafio-final-trilha-net-tests`.

### Para compilar o projeto
```bash
dotnet build
```
## Para executar o projeto
```
cd Calculadora-Tests
dotnet test
```

## Estrutura do Projeto
- `Calculadora.cs`: Contém a implementação da calculadora com os métodos `Somar`, `Subtrair`, `Multiplicar` e `Dividir`.
- `UnitTest1.cs`: Contém os testes unitários para os métodos da calculadora.
