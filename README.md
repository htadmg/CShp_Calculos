# CShp_Calculos - Calculadora de Operações Matemáticas

Este é um projeto C# que contém uma classe `Calculo` com métodos para realizar operações matemáticas básicas, como soma, subtração, multiplicação e divisão.

## Testes Unitários

O projeto também inclui testes unitários utilizando a biblioteca de testes `Xunit`. Os testes garantem que as operações matemáticas funcionam conforme o esperado.

## Funcionalidades

- `Somar`: Realiza a adição de dois números.
- `Subtrair`: Realiza a subtração de dois números.
- `Multiplicar`: Realiza a multiplicação de dois números.
- `Dividir`: Realiza a divisão de dois números.
- `IsNumeroPar`: Verifica se um número é par.

## Como Usar

1. Adicione a referência ao projeto `CShp_Calculos` em sua solução.
2. Utilize os métodos da classe `Calculo` para realizar operações matemáticas.

Exemplo de uso:

```csharp
double resultadoSoma = Calculo.Somar(2.9, 3.1);
double resultadoSubtracao = Calculo.Subtrair(2.9, 3.1);
double resultadoMultiplicacao = Calculo.Multiplicar(2.9, 3.1);
double resultadoDivisao = Calculo.Dividir(2.9, 3.1);
bool ehPar = Calculo.IsNumeroPar(4);
