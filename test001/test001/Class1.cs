using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test001
{
    class Class1
    {
        static void Main(string[] args)
        {
            List<List<float>> matrizValues = new List<List<float>>();
            List<float> beamDistance = new List<float>();
            float inicio = 0;
            float final = 24;
            float maxBarilla = 8;
            char tipo = 'i'; //i para inferior y s para superior

            //Valores de la distancia de las vigas
            beamDistance.Add(2);
            beamDistance.Add(4);
            beamDistance.Add(6);
            beamDistance.Add(8);
            beamDistance.Add(4);

            Console.WriteLine("Prueba algoritmo: \n");

            BarillaUtils al = new BarillaUtils();

            matrizValues = al.algorimZen(inicio, final, maxBarilla, beamDistance, tipo);
            al.pintarMatriz(matrizValues);

            Console.In.ReadLine();
        }
    }
}
