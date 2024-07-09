using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Postman
{
    public class FindWay
    {
        public int n; // Число вершин
        

        public List<int[]> Center(List<int[]> point)
        {
            int n = point.Count;
            List<int[]> pointNew = new List<int[]>();
            for (int i =0; i<n; i++)
            {
                int[] p = new int[] { point[i][0]+20, point[i][1]+8 };
                pointNew.Add(p);
            }
            return pointNew;
        }

        public int[,] MatrixSmeg(List<int[]> point)//получение матрицы смежности
        {
            n = point.Count;
            int[,] matrix = new int[n,n];
            for(int i =0; i<n; i++)
            {
                for( int j =0; j<n; j++)
                {
                    if (i == j)
                        matrix[i,j] = -1;
                    else
                    {
                        matrix[i,j] = (int)Math.Sqrt(Math.Abs( Math.Pow(point[i][0] - point[j][0],2) + Math.Pow(point[i][1] - point[j][1], 2)));
                        matrix[j, i] = matrix[i, j];
                    }
                }
            }

            return matrix;
        }

        //жадное решение
        public List<int> FindMinRoute(int[,] tsp)
        {
            int counter = 0;
            int j = 0, i = 0;
            int min = int.MaxValue;

            List<int> visitedRouteList = new List<int>();

            visitedRouteList.Add(0);
            int[] route = new int[tsp.Length];

            while (i < tsp.GetLength(0) && j < tsp.GetLength(1))
            {

               
                if (counter >= tsp.GetLength(0) - 1)
                {
                    break;
                }

                if (j != i &&
                    !(visitedRouteList.Contains(j)))
                {
                    if (tsp[i, j] < min)
                    {
                        min = tsp[i, j];
                        route[counter] = j + 1;
                    }
                }
                j++;

                if (j == tsp.GetLength(0))
                {
                    min = int.MaxValue;
                    visitedRouteList.Add(route[counter] - 1);

                    j = 0;
                    i = route[counter] - 1;
                    counter++;
                }
            }

            return visitedRouteList;
        }
       
        public List<int[]> ReternPath(List<int[]> point1, List<int> visitedRouteList)
        {
            List<int[]> pointNew = new List<int[]>();
            for (int i=0; i < visitedRouteList.Count;i++)
            {
                int n = visitedRouteList[i];
                int[] p = new int[] { point1[n][0], point1[n][1] };
                pointNew.Add(p);
            }

            return pointNew;
        }
    }
}