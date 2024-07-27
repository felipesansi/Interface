# Projeto de Interface em C#

Este repositório contém um exemplo de implementação de interfaces em C#. O projeto demonstra como definir e implementar uma interface, bem como utilizá-la em classes concretas.

## Estrutura do Projeto

- **`IConta.cs`**: Define a interface `IConta` com métodos para saque e cálculo.
- **`ContaCorrente.cs`**: Implementa a interface `IConta` e herda da classe `Conta`. Adiciona a funcionalidade de limite de crédito.
- **`Conta.cs`**: Classe base que representa uma conta bancária com propriedades como titular, agência, número e saldo. Inclui métodos para depósito.

## Detalhes das Classes

### Interface `IConta`

```csharp
public interface IConta
{
    void Sacar(double valor);
    double Calcular();
}