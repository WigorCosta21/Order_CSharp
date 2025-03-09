# OrderApp

OrderApp é um sistema simples de gestão de pedidos desenvolvido em C#. Ele permite cadastrar clientes, adicionar pedidos com múltiplos itens e exibir um resumo completo do pedido.

## Funcionalidades
- Cadastro de cliente (Nome, E-mail, Data de nascimento)
- Cadastro de pedido (Data e Status)
- Adição de itens ao pedido (Produto, Preço, Quantidade)
- Cálculo do total do pedido
- Exibição do resumo do pedido

## Tecnologias Utilizadas
- C#
- .NET
- POO (Programação Orientada a Objetos)
- Enumerações
- Listas
- Manipulação de datas

## Estrutura do Projeto
O projeto está dividido nos seguintes componentes:
- **Program.cs**: Ponto de entrada do sistema, onde os dados são coletados e processados.
- **Entities/**: Contém as classes principais do sistema:
  - `Client`: Representa o cliente do pedido.
  - `Order`: Representa um pedido e seus itens.
  - `OrderItem`: Representa um item dentro do pedido.
  - `Product`: Representa um produto.
- **Entities/Enums/**: Contém a enumeração `OrderStatus` para status do pedido.

## Como Executar o Projeto
1. Certifique-se de ter o .NET SDK instalado.
2. Clone este repositório:
   ```sh
   git clone https://github.com/seu-usuario/OrderApp.git
   ```
3. Acesse a pasta do projeto:
   ```sh
   cd OrderApp
   ```
4. Compile e execute o programa:
   ```sh
   dotnet run
   ```
5. Siga as instruções no terminal para inserir os dados.

## Exemplo de Uso
```
Enter client data:
Name: João Silva
Email: joao@email.com
Birth date (DD/MM/YYYY): 15/08/1985

Enter order data:
Status: Processing
How many items to this order: 2

Enter #1 item data:
Product name: Laptop
Product Price: 3500.00
Quantity: 1

Enter #2 item data:
Product name: Mouse
Product Price: 150.00
Quantity: 2

ORDER SUMMARY:
Order moment: 09/03/2025 14:30:15
Order status: Processing
Client: João Silva (15/08/1985) - joao@email.com
Order items:
Laptop, $3500.00, Quantity: 1, Subtotal: $3500.00
Mouse, $150.00, Quantity: 2, Subtotal: $300.00
Total price: $3800.00
```



