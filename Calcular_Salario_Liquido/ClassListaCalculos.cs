using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Salario_Liquido
{
    internal class ClassListaCalculos
    {
        public string nome;
        public double slb;
        public double outros_desc;
        public double dep;
        public double inss;
        public double irrf;
        public double sll;

        // contrutor
        public ClassListaCalculos(string _nome, double _slb, double _outos_desc, double _dep, double _inss, double _irrf, double _sll) 
        {
            nome = _nome;
            slb = _slb;
            outros_desc = _outos_desc;
            dep = _dep;
            inss = _inss;
            irrf = _irrf;
            sll = _sll;

        }

    }
}
