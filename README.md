# OrderApp

OrderApp � um sistema simples de gest�o de pedidos desenvolvido em C#. Ele permite cadastrar clientes, adicionar pedidos com m�ltiplos itens e exibir um resumo completo do pedido.

## Funcionalidades
- Cadastro de cliente (Nome, E-mail, Data de nascimento)
- Cadastro de pedido (Data e Status)
- Adi��o de itens ao pedido (Produto, Pre�o, Quantidade)
- C�lculo do total do pedido
- Exibi��o do resumo do pedido

## Tecnologias Utilizadas
- C#
- .NET
- POO (Programa��o Orientada a Objetos)
- Enumera��es
- Listas
- Manipula��o de datas

## Estrutura do Projeto
O projeto est� dividido nos seguintes componentes:
- **Program.cs**: Ponto de entrada do sistema, onde os dados s�o coletados e processados.
- **Entities/**: Cont�m as classes principais do sistema:
  - `Client`: Representa o cliente do pedido.
  - `Order`: Representa um pedido e seus itens.
  - `OrderItem`: Representa um item dentro do pedido.
  - `Product`: Representa um produto.
- **Entities/Enums/**: Cont�m a enumera��o `OrderStatus` para status do pedido.

## Como Executar o Projeto
1. Certifique-se de ter o .NET SDK instalado.
2. Clone este reposit�rio:
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
5. Siga as instru��es no terminal para inserir os dados.

## Exemplo de Uso
```
Enter client data:
Name: Jo�o Silva
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
Client: Jo�o Silva (15/08/1985) - joao@email.com
Order items:
Laptop, $3500.00, Quantity: 1, Subtotal: $3500.00
Mouse, $150.00, Quantity: 2, Subtotal: $300.00
Total price: $3800.00
```



