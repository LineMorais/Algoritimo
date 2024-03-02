public class Estoque
{

    Brinquedo[] brinquedos = new Brinquedo[0];


    public void Novo(Brinquedo brinquedo)
    {
        Brinquedo[] novoVetor = new Brinquedo[brinquedos.Length + 1];
        for (int pos = 0; pos < brinquedos.Length; pos++)
        {
            Brinquedo item = brinquedos[pos];
            novoVetor[pos] = item;
        }
        novoVetor[novoVetor.Length -1] = brinquedo;

        brinquedos = novoVetor;
    }

    public void Listar()
    {
        int cont = 1;
        foreach (Brinquedo item in brinquedos)
        {
            Console.WriteLine($"{cont}. {item.Codigo} - {item.NomeBrinquedo}, {item.Categoria}, {item.Fabricante}, {item.IdadeRecomendada} anos\r\n {item.Preco,0:C} - Qtd em estoque {item.QtdEstoque} un");
            cont++;
        }
    }
    public void Entrada(int pos, int qtd)
    {
        Brinquedo brinquedo = brinquedos[pos - 1];
        brinquedo.QtdEstoque += qtd;
    }

    public void Saida(int pos, int qtd)
    {
        Brinquedo brinquedo = brinquedos[pos - 1];
        brinquedo.QtdEstoque -= qtd;
    }
     public void Remover(int pos)
    {
        Brinquedo[] apagarVetor = new Brinquedo[brinquedos.Length -1];
        for (int i = 0; i < brinquedos.Length; i++)
        {
            if (i != pos -1) 
            {
                Brinquedo item = brinquedos[i];
                apagarVetor[i] = item;  
            }
        }

        brinquedos = apagarVetor;
    }

}
