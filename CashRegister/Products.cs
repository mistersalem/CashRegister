using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CashRegister
{
    class Products
    {

        //public class CustomArray<T>
        //{
        //    public T[] GetColumn(T[,] matrix, int columnNumber)
        //    {
        //        return Enumerable.Range(0, matrix.GetLength(0))
        //                .Select(x => matrix[x, columnNumber])
        //                .ToArray();
        //    }

        //    public T[] GetRow(T[,] matrix, int rowNumber)
        //    {
        //        return Enumerable.Range(0, matrix.GetLength(1))
        //                .Select(x => matrix[rowNumber, x])
        //                .ToArray();
        //    }
        //}

        //public void ProductsArrayCreator()
        //{
        //    object[,] ProductsFullArray = new object[,]
        //    {
        //        {1, "Tomatos" },
        //        {2, "Potatos" },
        //    };

        //    int index = 0;

        //    int numberOfRows = ProductsFullArray.GetLength(0);
        //    int numberOfColumns = ProductsFullArray.GetLength(1);

        //    object[] ProductsNameArray = new object[numberOfRows * numberOfColumns];

        //    for (int i = 0; i < numberOfColumns; i++)
        //    {
        //        for (int j = 0; j < numberOfRows; j++)
        //        {
        //            ProductsNameArray[index] = ProductsFullArray[j, i];
        //            index++;
        //        }
        //    }


        //    //object[] ProductsNameArray = CustomArray<object>.GetColumn(ProductsFullArray[], 2);


        //    //object[][] ProductsArray = new object[1][];
        //    //ProductsArray[0] = new object[] { 1, 2, 3, 4, 5 };
        //    //ProductsArray[1] = new object[] { "Tomatos", "Potatos", "Cabbages", "Cucumbers", "Onions" };


        //}
         
        class ByWeightProducts
        {

            public void Vegetables()
            {

                Tuple<string, string, double> Tomatoes(double weight)
                {
                    string code = "001";
                    string name = "Tomatoes";
                    double pricePerKg = 3.14;
                    double fPrice = weight * pricePerKg;
                    return Tuple.Create(code, name, fPrice);
                }


                Tuple<string, string, double> Potatoes(double weight)
                {
                    string code = "002";
                    string name = "Tomatoes";
                    double pricePerKg = 1.20;
                    double fPrice = weight * pricePerKg;
                    return Tuple.Create(code, name, fPrice);
                }

                Tuple<string, string, double> Cabbages(double weight)
                {
                    string code = "003";
                    string name = "Tomatoes";
                    double pricePerKg = 3.99;
                    double fPrice = weight * pricePerKg;
                    return Tuple.Create(code, name, fPrice);
                }

                //double Cabbages(double weight)
                //{
                //    double pricePerKg = 3.99;
                //    return weight * pricePerKg;
                //}

                //double Cucumbers(double weight)
                //{
                //    double pricePerKg = 5.20;
                //    return weight * pricePerKg;
                //}

                //double Onions(double weight)
                //{
                //    double pricePerKg = 2.67;
                //    return weight * pricePerKg;
                //}

            }

        }
    }
}
