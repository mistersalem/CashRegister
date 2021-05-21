using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            ProductsArrayCreator();
            
            vegeComboBox();

            //nameComboBox.ItemsSource = _nameComboBoxSource;
            //nameComboBox.SelectionChanged += nameComboBox_SelectionChanged;


        }

        readonly string[] vegetables = { "1", "2" };
        private bool windowShowFirstTime = true;

        public void vegeComboBox()
        {
            nameComboBox.ItemsSource = ProductsNameArray;
        }

        object[] ProductsNameArray;


        
        // This meth create 1d array of products names for combobox
        public void ProductsArrayCreator()
        {
            object[,] ProductsFullArray = new object[,]
            {
                {1, "Tomatoes" },
                {2, "Potatoes" },
                {3, "Onions" },
            };

            int index = 0;

            int numberOfRows = ProductsFullArray.GetLength(0);
            int numberOfColumns = ProductsFullArray.GetLength(1);


            ProductsNameArray = new object[numberOfRows];


                for (int j = 0; j < numberOfRows; j++)
                {
                    ProductsNameArray[index] = ProductsFullArray[j, 1];
                    index++;
                }
            

        }

        private void nameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(nameComboBox.SelectedItem.ToString());
        }

        //private void btAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show(this.nameComboBox.SelectedItem.ToString());
        //}




    }


}
