using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test001
{
    class BarillaUtils
    {
        public List<List<float>> algorimZen(float inicio, float final, float maxBarilla, List<float> beamDistance, char tipo)
        {
            List<float> pointDistance = new List<float>();
            List<float> corteBarilla = new List<float>();
            List<List<float>> matrizValues = new List<List<float>>();

            float temp = 0;

            switch (tipo)
            {
                case 's':
                    //algoritmo para hallar la distancia entre mitades para superior
                    foreach (float x in beamDistance)
                    {
                        temp = temp + (x / 2);
                        pointDistance.Add(temp);
                        temp = (x / 2);
                    }
                    pointDistance.Add(temp);
                    break;
                case 'i':
                    pointDistance = beamDistance;
                    break;
                default:
                    Console.WriteLine("No tipo encontrado");
                    break;
            }

            float sumBarilla = 0;
            float beamLimit = 0;
            float finBarilla = 0;
            int contPointDistance = 0;
            do
            {
                temp = 0;
                beamLimit = 0;
                contPointDistance = 0;
                foreach (float x in pointDistance)
                {
                    temp = temp + x;
                    if (temp > maxBarilla)
                    {
                        corteBarilla.Add(beamLimit);
                        pointDistance.RemoveRange(0, contPointDistance);
                        finBarilla = sumBarilla + beamLimit;
                        break;
                    }
                    beamLimit = temp;
                    contPointDistance++;
                }
                sumBarilla = sumBarilla + beamLimit;
            } while (final >= sumBarilla);

            corteBarilla.Add(final - finBarilla);

            matrizValues.Add(corteBarilla);

            return matrizValues;
        }

        public void pintarMatriz(List<List<float>> matriz)
        {
            foreach (List<float> nodeMatriz in matriz)
            {
                foreach (float x in nodeMatriz)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
