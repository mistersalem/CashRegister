using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace CashRegister
{



    public class Products
    {

        //Products Table
        public static DataTable GetTable()
        {
            // Create a DataTable
            DataTable table = new DataTable();
            DataColumn dtColumn;
            DataRow dtRow;

            // Create ProductID column
            dtColumn = new DataColumn();
            dtColumn.DataType = Type.GetType("System.Int32");
            dtColumn.ColumnName = "ProductId";
            dtColumn.AutoIncrement = true;
            dtColumn.Caption = "Product ID";
            dtColumn.ReadOnly = true;
            dtColumn.Unique = true;
            table.Columns.Add(dtColumn);

            // Create Name column
            dtColumn = new DataColumn();
            dtColumn.DataType = Type.GetType("System.String");
            dtColumn.ColumnName = "Name";
            dtColumn.Caption = "Product Name";
            table.Columns.Add(dtColumn);

            // Create byWeight column

            dtColumn = new DataColumn();
            dtColumn.DataType = Type.GetType("System.Boolean");
            dtColumn.ColumnName = "byWeight";
            dtColumn.Caption = "Is price by weight?";
            table.Columns.Add(dtColumn);

            // Create price column
            dtColumn = new DataColumn();
            dtColumn.DataType = Type.GetType("System.Double");
            dtColumn.ColumnName = "Price";
            dtColumn.Caption = "Product price";
            table.Columns.Add(dtColumn);

            // Add rows with products info
            dtRow = table.NewRow();
            dtRow["ProductId"] = 0;
            dtRow["Name"] = "Tomatoes";
            dtRow["byWeight"] = true;
            dtRow["Price"] = 3.14;
            table.Rows.Add(dtRow);

            dtRow = table.NewRow();
            dtRow["ProductId"] = 1;
            dtRow["Name"] = "Potatoes";
            dtRow["byWeight"] = true;
            dtRow["Price"] = 1.20;
            table.Rows.Add(dtRow);

            dtRow = table.NewRow();
            dtRow["ProductId"] = 2;
            dtRow["Name"] = "Onions";
            dtRow["byWeight"] = true;
            dtRow["Price"] = 2.80;
            table.Rows.Add(dtRow);

            dtRow = table.NewRow();
            dtRow["ProductId"] = 3;
            dtRow["Name"] = "Cabbages";
            dtRow["byWeight"] = true;
            dtRow["Price"] = 3.99;
            table.Rows.Add(dtRow);

            dtRow = table.NewRow();
            dtRow["ProductId"] = 4;
            dtRow["Name"] = "Cucumbers";
            dtRow["byWeight"] = true;
            dtRow["Price"] = 5.20;
            table.Rows.Add(dtRow);

            return table;
        }


        

         
        public class ByWeightProducts
        {
           



            

        }
    }
}
