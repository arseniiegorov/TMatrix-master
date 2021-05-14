using System;
using System.IO;
using LR4;
using NUnit.Framework;

namespace TMatrixTest
{
    [TestFixture]
    public class Tests
    {
        private const int matrix_col = 3;
        private const int matrix_row = 2;
        
        private TMatrix matrix = null;
        
        int[,] mass = {
            {1,1}, {2,2}, {3,3}
        };
        
        
        
        [Test]
        public void testTMatrix()
        {
            matrix = new TMatrix(matrix_col, matrix_row);

            Assert.NotNull(matrix);
        }

        [Test]
        public void testInputTMatrix()
        {
            matrix = new TMatrix(matrix_col, matrix_row);
            
            matrix.InputMatrix(mass);

            Assert.AreEqual(mass, matrix.Mass);
        }
        
        [Test]
        public void testOutputTMatrix()
        {
            matrix = new TMatrix(matrix_col, matrix_row);

            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                matrix.Show();

                Assert.AreEqual( "0 0  \r\n0 0  \r\n0 0  \r\n" , sw.ToString());
            }
        }
        
        [Test]
        public void testSumTMatrix()
        {
            matrix = new TMatrix(matrix_col, matrix_row);
            var matrix2 = new TMatrix(matrix_col, matrix_row);
            
            matrix.InputMatrix(mass);
            
            matrix2.InputMatrix(mass);
            
            matrix.Sum(matrix2);
            
            Assert.AreEqual(new int[,]{ {2,2}, {4,4}, {6,6}}, matrix.Mass);
        }

    }
}