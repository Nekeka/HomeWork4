using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    internal class Matrix
    {
        private double[,] A;
        private int size;
        private void createMatrix()
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    A[i, j] = rnd.Next(-9, 9);
        }

        public Matrix(int size)
        {
            A = new double [size, size];
            this.size = size;
            createMatrix();
        }
        public Matrix(double[,] matrix, int size)
        {
            A = matrix;
            this.size = size;
            
        }
        private Matrix(int size, bool empty) { A = new double[size, size]; this.size = size; }
        //
        private Matrix() => A = new double[size, size];
        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < size; j++)
                    Console.Write(A[i, j] + ",");
            }
            Console.WriteLine();
        }
        
        public double this[int index_i, int index_j]
        {
            get => A[index_i, index_j];
            set => A[index_i, index_j] = value;
        }

        public static Matrix operator +(Matrix A, Matrix T)
        {
            Matrix new_matrix = new Matrix(A.size,true) ;
            for (int i = 0; i < A.size; i++)
                for (int j = 0; j < A.size; j++)
                    new_matrix[i, j] = A[i, j] + T[i, j];
            return new_matrix;
                
        }
        public static Matrix operator -(Matrix A, Matrix T)
        {
            Matrix new_matrix = new Matrix(A.size, true);
            for (int i = 0; i < A.size; i++)
                for (int j = 0; j < A.size; j++)
                    new_matrix[i, j] = A[i, j] - T[i, j];
            return new_matrix;
        }
        public static Matrix operator *(Matrix A, Matrix T)
        {
            Matrix new_matrix = new Matrix(A.size, true);
            for (int i = 0; i < A.size; i++)
                for (int j = 0; j < A.size; j++)
                {
                    for (int k = 0; k < A.size; k++)
                        new_matrix[i, j] = new_matrix[i, j] + A[i, k] * T[k, j];
                }
            return new_matrix;
        }
        public static Matrix operator *(Matrix A, double scalar)
        {
            Matrix new_matrix = new Matrix(A.size, true);
            for (int i = 0; i < A.size; i++)
                for (int j = 0; j < A.size; j++)
                {
                    new_matrix[i, j] = A[i, j] * scalar; 
                }
            return new_matrix;
        }
        public static bool operator ==(Matrix A, Matrix T)
        {
            for (int i = 0; i < A.size; i++)
                for (int j = 0; j < A.size; j++)
                    if (A[i, j] != T[i, j])
                        return false;

            return true;
        }
        public static bool operator !=(Matrix A, Matrix T)
        {
            for (int i = 0; i < A.size; i++)
                for (int j = 0; j < A.size; j++)
                    if (A[i, j] != T[i, j])
                        return true;

            return false;
        }



    }
}
