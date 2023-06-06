using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo mảng hai chiều
            int[,] array =
            {
                {1, 2, 3, 6 },
                {2, 13, 4, 5 },
                {3, 4, 5, 6 },
                {4, 5, 13, 9 },
            };
            //khoi tao bien so de chua gia tri lon nhat
            int giaTri_LonNhat = array[0, 0];

            //Khai bao bien nguyen de chua gia tri lon nhat
            //int hang = 0;
            //int cot = 0;

            //khai bao danh sach de luu toa do cua phan tu lon nhat
            List<int[]> toaDo_LonNhat = new List<int[]>();


            //duyet qua cac phan tu cua ma tran 
            for (int i = 0; i< array.GetLength(0); i++)
            {
                for (int j = 0; j< array.GetLength(1); j++)
                {
                    if (array[i,j] > giaTri_LonNhat)
                    {
                        giaTri_LonNhat = array[i,j];
                        toaDo_LonNhat.Clear();
                        toaDo_LonNhat.Add(new int[] { i, j });

                    }
                    else if (array[i,j] == giaTri_LonNhat)
                    {
                        toaDo_LonNhat.Add(new int[] { i, j});
                    }
                }
            }


            //hiển thị
            Console.WriteLine("Ma trận:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Giá trị lớn nhất: " + giaTri_LonNhat);
            Console.WriteLine("Tọa độ của giá trị lớn nhất: ");
            foreach (int[] toa_Do in toaDo_LonNhat)
            {
                Console.WriteLine("(" + toa_Do[0] + ", " + toa_Do[1] + ")");
            }

            Console.ReadKey();
        }
    }
}
