using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_student
{
    static public class Sensor
    {
        public struct AvarageBySensor
        {
            public ushort code;
            public double value;

        }

        
           static public void AvarageData(AvarageBySensor[] AvarageArrey, int countOfSensor)
            {

                double[,] SensorDataRezult=new double[countOfSensor, 2];

                for (int i = 0; i < AvarageArrey.Length; i++)
                {
                    for (int k = 0; k < countOfSensor;k++ )
                    {
                        if (AvarageArrey[i].code == k+1)
                        {
                            SensorDataRezult[k, 0] += AvarageArrey[i].value;
                            SensorDataRezult[k, 1] += 1;
                        }
                    }

                }

               //напечатаем, что мы получили в итоге
                for (int k = 0; k < countOfSensor; k++ )
                { 
                    Console.WriteLine("Data from first sensor {0}", SensorDataRezult[k,0]/ SensorDataRezult[k,1]);
                }
                   
            }

        public static void ParsingData(ushort [] data, int countOfSensor)
        {
            int[] parity = new int[data.Length]; //счетчик единиц
            int lastByte = 0;
            ushort codeRezult;
            double valueRezult;
            
            List<Sensor.AvarageBySensor> AvarageList=new List<AvarageBySensor>();
            for (int t = 32768; t > 0; t /= 2)
            {
                for (int arreyCount = 0; arreyCount < data.Length; arreyCount++)
                {
                    if (t != 1)
                    {
                        if ((data[arreyCount] & t) != 0)
                        {
                            parity[arreyCount]++;
                        }

                    }
                    else
                    {
                        lastByte = data[arreyCount] & t;
                        if (((lastByte == 1) && (parity[arreyCount] % 2 != 0)) || ((lastByte == 0) && (parity[arreyCount] % 2 == 0)))
                        {
                            //разбираем информацию на составляющие
                            project_student.Sensor.AvarageBySensor Average;

                            codeRezult = (ushort)(data[arreyCount] >> 13);
                            Average.code = codeRezult;

                            valueRezult = (double)((data[arreyCount] >> 1) & 0xFFF);
                            Average.value = valueRezult;

                           // Console.WriteLine("Element {0:X} is correct", data[arreyCount]);

                            //забиваем данные в массив
                            AvarageList.Add(Average);

                        }

                    }

                }

            }

            project_student.Sensor.AvarageBySensor[] AvarageArrey = AvarageList.ToArray();
            project_student.Sensor.AvarageData(AvarageArrey, countOfSensor);
        }
    }
}
