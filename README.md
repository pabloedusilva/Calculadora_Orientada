# 🖩 Calculadora em C#

Este projeto consiste em uma calculadora simples desenvolvida em C#. A aplicação permite ao usuário realizar operações matemáticas básicas, como adição, subtração, multiplicação e divisão, com dois números decimais fornecidos.

## ⚙️ Estrutura do Projeto

O código está organizado em três arquivos principais:

### 1. **Calculadora.cs**
   - Contém a classe `Operacoes` com métodos para realizar as operações matemáticas.
   - **Métodos disponíveis:**
     - `Adicao(decimal valor1, decimal valor2)`: Realiza a soma entre dois valores.
     - `Subtraçao(decimal valor1, decimal valor2)`: Realiza a subtração entre dois valores.
     - `Multiplicacao(decimal valor1, decimal valor2)`: Realiza a multiplicação entre dois valores.
     - `Divisao(decimal valor1, decimal valor2)`: Realiza a divisão entre dois valores.

### 2. **Menu.cs**
   - Contém a classe `MenuOperacoes` responsável por exibir o menu de operações para o usuário.
   - O método `ImprimirMenu()` exibe as opções de operações matemáticas disponíveis.

### 3. **Program.cs**
   - Arquivo principal onde a aplicação é executada.
   - Solicita ao usuário os dois números e a operação desejada.
   - Usa a estrutura de controle `switch` para chamar o método correspondente da classe `Operacoes` com base na operação escolhida pelo usuário.

## 📌 Como Usar

1. Ao executar o programa, o usuário será solicitado a inserir o primeiro número.
2. Em seguida, o menu de operações será exibido, com as opções de adição, subtração, multiplicação e divisão.
3. O usuário deve escolher uma operação e, em seguida, inserir o segundo número.
4. O resultado da operação será exibido no console.

## 📌 Exemplo de Execução

![image](https://github.com/user-attachments/assets/c77c1a89-12c8-4f47-b25b-7771fd9e78ab)


## ✔️ Validação de Entrada

- O programa utiliza a função `decimal.TryParse()` para validar se os números digitados são válidos. Caso o usuário insira um valor inválido, o programa solicitará novamente a entrada.
- O programa também lida com operações de divisão, com a possibilidade de erro de divisão por zero.

## 📌 Contribuições

Se você deseja contribuir para este projeto, fique à vontade.

<img src="https://github.com/user-attachments/assets/6046bd8f-8ec5-4318-ac01-55cd5ebb27e7" width="150" height="150">

