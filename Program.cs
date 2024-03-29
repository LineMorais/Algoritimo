﻿using System.ComponentModel.Design;

namespace Projeto_de_Estoque;
class Program
{
    static void Main(string[] args)
    {
    
        Estoque estoque  = new Estoque();

        int menu  = 0;
        do
        {
            Console.WriteLine("\n##CONTROLE DE ESTOQUE##");

            Console.WriteLine("\nO que deseja fazer?");

            Console.WriteLine("[1] Novo");
            Console.WriteLine("[2] Listar Produtos");
            Console.WriteLine("[3] Remover Produtos");
            Console.WriteLine("[4] Entrada Qtd Estoque");
            Console.WriteLine("[5] Saída Qtd Estoque");
            Console.WriteLine("[0] Sair");
            menu = Convert.ToInt32(Console.ReadLine());
        
            if(menu == 1)
            {
                Brinquedo novoBrinquedo = new Brinquedo();

                Console.WriteLine("Código: ");
                novoBrinquedo.Codigo = Console.ReadLine();

                Console.WriteLine("Nome do Briquedo: ");
                novoBrinquedo.NomeBrinquedo = Console.ReadLine();

                Console.WriteLine("Categoria: ");
                novoBrinquedo.Categoria = Console.ReadLine();

                Console.WriteLine("Fabricante: ");
                novoBrinquedo.Fabricante = Console.ReadLine();

                Console.WriteLine("Idade recomendada: ");
                novoBrinquedo.IdadeRecomendada = Console.ReadLine();

                Console.WriteLine("Preço: ");
                novoBrinquedo.Preco = Convert.ToDouble(Console.ReadLine());

                estoque.Novo(novoBrinquedo);

                Console.WriteLine("Brinquedo adicionado!");

            }
            else if (menu == 2)
            {
                Console.WriteLine("\nItens no Estoque: ");             
                estoque.Listar();
            }
            else if (menu == 3)
            {
                Console.WriteLine("\nItens no Estoque: ");             
                estoque.Listar();

                Console.WriteLine("Posição do brinquedo na lista de estoque que deseja remover: ");
                int pos = Convert.ToInt32(Console.ReadLine());

                estoque.Remover(pos);
               
            }
            else if (menu == 4)
            {
                Console.WriteLine("\nItens no Estoque: ");             
                estoque.Listar();

                Console.WriteLine("Posição do brinquedo na lista de estoque: ");
                int pos = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Quantidade de entrada no estoque: ");
                int qtd = Convert.ToInt32(Console.ReadLine());

                estoque.Entrada(pos, qtd);

            }
            else if (menu == 5)
            {
                Console.WriteLine("\nItens no Estoque: ");             
                estoque.Listar();

                Console.WriteLine("Posição do brinquedo na lista de estoque: ");
                int pos = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Quantidade de saida do estoque: ");
                int qtd = Convert.ToInt32(Console.ReadLine());

                estoque.Saida(pos, qtd);
            }
        }
        while (menu != 0);
        Console.WriteLine("O sistema foi fechado.");
    }
}
