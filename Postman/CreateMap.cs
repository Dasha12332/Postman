using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Postman
{
    internal class CreateMap
    {
        public int[,] Create()
        {
            Random rnd = new Random();
            int[,] koord = new int[2,150];

            for(int i = 0; i < 150; i++) {

                //генерация координат угла здания
                int rx = rnd.Next(600);
                int ry = rnd.Next(600);
                bool goodKoord = true;
                //проверка отстоит ли текущее здание от уже сгенерированных на достаточное расстояние
                for(int j = 0; j <i; j++)
                {
                    if ((Math.Abs(koord[0, j] - rx) < 45) &&
                        (Math.Abs(koord[1, j] - ry) < 20))
                    {
                        goodKoord = false;
                        break;
                    }
                }
                if (goodKoord) //если отстоит, то добовляем переменную в файл
                {
                    koord[0, i] = rx;
                    koord[1, i] = ry;
                }
                else
                    i--;  
            }
            return koord;
        }
    }
}
