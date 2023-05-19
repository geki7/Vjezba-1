using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica.Models
{
    internal class TecajnaLista
    {
        public List<Tecaj> tecajnaLista;
        public TecajnaLista()
        {
            tecajnaLista = new List<Tecaj>();
            tecajnaLista.Add(new Tecaj("EUR", 7.5));
            tecajnaLista.Add(new Tecaj("USD", 6.4));
            tecajnaLista.Add(new Tecaj("CAD", 5.5));
        }
    }
}
