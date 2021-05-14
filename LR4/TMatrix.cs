using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR4
{

  public  class TMatrix
    {
        private int col, row;
        private int[,] mass;

        public TMatrix(int col, int row)
        {
            this.col = col;
            this.row = row;
            this.mass = new int[col, row];
        }

        public void Sum(TMatrix matrix)
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    mass[i, j] = mass[i, j] + matrix.mass[i,j];
                }
            }
        }

        public void InputMatrix()
        {
            for (int i = 0; i < Col; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    Mass[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        
        public void InputMatrix(int[,] in_mass)
        {
            for (int i = 0; i < Col; i++)
            {
                for (int j = 0; j < Row; j++)
                {
                    Mass[i, j] = in_mass[i, j];
                }
            }
        }


        public void Show()
        {
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(mass[i,j].ToString() + " ");
                }
                Console.WriteLine(" ");
            }
        }

        public int Col { get => col; set => col = value; }
        public int Row { get => row; set => row = value; }
        public int[,] Mass { get => mass; set => mass = value; }
    }
}
