using System;
using System.Globalization;


namespace lanche {
    class Program {
       static void Main(string[] args)
       {
       int cod, qtde;
       double preco;
       string lanche;

       Console.WriteLine( @"Digite o codigo desejado:
       CODIGO      ESPECIFICAÇÃO      PREÇO 
       1-----------Cachorro Quente----R$ 4.00
       2-----------X-salada-----------R$ 4.50
       3-----------X-bacon------------R$ 5.00
       4-----------Torrada simples----R$ 5.50
       5-----------Refrigerante-------R$ 1.50");
       cod = int.Parse(Console.ReadLine());
       Console.WriteLine( "Digite a quantidade desejada: ");
       qtde = int.Parse(Console.ReadLine());

       switch (cod) {
        case 1:
            lanche = "cachorro quente";
            preco = 4.00;
            break;
        case 2:
            lanche = "x-salada";
            preco = 4.50;
            break;
        case 3:
            lanche = "x-bacon";
            preco = 5.00;
            break;
        case 4:
            lanche = "torrada simples";
            preco = 2.00;
            break;
        case 5:
            lanche = "Refrigerante";
            preco = 1.50;
            break;
        default:
            Console.WriteLine("Codigo invalido.");
            return;


       }
       double total = qtde * preco;

       Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
       Console.ReadLine();
    }
    }

}
