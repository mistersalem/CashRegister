using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CashRegister
{
    /// <summary>
    /// Logika interakcji dla klasy Page1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {

            InitializeComponent();

            NameArrayCreator();

            vegeComboBox();

            


        }



        public void vegeComboBox()
        {
            //nameComboBox.ItemsSource = ProductsNameArray;

            nameComboBox.ItemsSource = productsTable.AsDataView();
        }

        DataTable productsTable =  Products.GetTable();
        object[] ProductsNameArray;

      
        // Create 1d array of products names for combobox
        public void NameArrayCreator()
        {

            int index = 0;

            int noRows = productsTable.Rows.Count;

            ProductsNameArray = new object[noRows];

            foreach (DataRow row in productsTable.Rows)
            {
                ProductsNameArray[index] = productsTable.Rows[index]["Name"].ToString();
                index++;
            }

        }

        private void nameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }





    }


}
