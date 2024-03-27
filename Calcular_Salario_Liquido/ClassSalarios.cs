using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Salario_Liquido
{
    internal class ClassSalarios
    {




        public static double CalcularINSS(double slb)
        {
            double inss = 0;

            if (slb <= 1412)
            {
                inss = (slb * 7.5 / 100);
            }
            else if (slb <= 2666.68)
            {
                inss = (slb * 9 / 100) - 21.18;
            }
            else if (slb <= 4000.03)
            {
                inss = (slb * 12 / 100) - 101.18;
            }
            else if (slb <= 7786.02)
            {
                inss = (slb * 14 /100) - 181.18;
            }
            else
            {
                inss = 7786.02 * 14 / 100 - 181.18;
            }

            return inss;
        }

        public static double CalcularIRRF(double saldo)
        {
            double IRRF = 0;

            if (saldo <= 2259.20)
            {
                IRRF = 0;
            }
            else if (saldo <= 2826.65)
            {
                IRRF = saldo * 7.5 / 100 - 169.44;
            }
            else if (saldo <= 3751.05)
            {
                IRRF = saldo * 15 / 100 - 381.44;
            }
            else if(saldo <= 4664.68)
            {
                IRRF = saldo * 22.5 / 100 - 662.77;
            }
            else
            {
                IRRF = saldo * 27.5 / 100 - 896.00;
            }

            return IRRF;
        }
    }

}
