using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{
    class Program
    {
        static void Main(string[] args)
        {

            TMatrix matrix = new TMatrix(2, 3);
            TMatrix matrix1 = new TMatrix(2, 3);
            matrix.InputMatrix();
            matrix1.InputMatrix();
            // matrix.Sum(matrix1);
            matrix.Show();


            Console.ReadKey();
        }
    }
}
