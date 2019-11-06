using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;

namespace Game_OO
{
    class Item
    {
        public string NomeItem; //Nome do item
        public double ValorItem; //Cada item coletado possui um valor diferente
        public int QuantidadeItem; //Quantidade de itens

        public double AtualizaInventario()
        {
            return ValorItem * QuantidadeItem;
        }

        public void AdicionaItens(int quantidade)
        {
            QuantidadeItem += quantidade;
        }

        public void RemoveItens(int quantidade)
        {
            QuantidadeItem -= quantidade;
        }

        public override string ToString()
        {
            return NomeItem
                + ", $ "
                + ValorItem.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + QuantidadeItem
                + " unidades, Total: $ "
                + AtualizaInventario().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
