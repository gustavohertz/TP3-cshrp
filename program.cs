using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TP3
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    class Program
    {
        static void Main()
        {
            string connectionString = "sua_string_de_conexao";

            // Exibir dados da tabela Produto
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectProdutoData = "SELECT * FROM Produto";
                using (SqlCommand command = new SqlCommand(selectProdutoData, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Dados da tabela Produto:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Nome: {reader["Nome"]}, Preço: {reader["Preco"]}");
                        }
                    }
                }
            }

            // Exibir dados da tabela Cliente
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectClienteData = "SELECT * FROM Cliente";
                using (SqlCommand command = new SqlCommand(selectClienteData, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\nDados da tabela Cliente:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Nome: {reader["Nome"]}, Email: {reader["Email"]}");
                        }
                    }
                }
            }

            // Exibir dados da tabela Pedido
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectPedidoData = "SELECT * FROM Pedido";
                using (SqlCommand command = new SqlCommand(selectPedidoData, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("\nDados da tabela Pedido:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"Id: {reader["Id"]}, Data do Pedido: {reader["DataPedido"]}, ClienteId: {reader["ClienteId"]}");
                        }
                    }
                }
            }
        }
    }

}
