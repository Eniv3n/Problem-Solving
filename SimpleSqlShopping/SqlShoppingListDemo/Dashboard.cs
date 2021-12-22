using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMUI
{
    public partial class Dashboard : Form
    {
        List<ProductClass> products = new List<ProductClass>();
        DataAccess db = new DataAccess();


        // Function that starts the UI and ensures the list displays what is in the DB
        public Dashboard()
        {
            InitializeComponent();
            products = db.GetProducts();
            UpdateBinding();
        }

        // Function that updates the information within the ListBox
        private void UpdateBinding()
        {
            productsInShoppingListBox.DataSource = products;
            productsInShoppingListBox.DisplayMember = "Product";
        }

        // Function call for "Add" button
        private void addButton_Click(object sender, EventArgs e)
        {
            db.AddProduct(addProductText.Text);
            products = db.GetProducts();
            UpdateBinding();
        }

        // Function call for "Clear all" button
        private void button1_Click(object sender, EventArgs e)
        {
            db.ClearList();
            products = db.GetProducts();
            UpdateBinding();

        }

        private void clearChecked_Click(object sender, EventArgs e)
        {
            /*if (productsInShoppingListBox.CheckedItems.Count != 0)
            {
                for (int x = 0; x < productsInShoppingListBox.CheckedItems.Count; x++)
                {

                Console.WriteLine(productsInShoppingListBox.Items.IndexOf(i))

                var output = db.ClearChecked(object holder);
                //var holder = output[]


                }

            */
            int listDecreasing = 0;/*
            int numOfChecks = productsInShoppingListBox.CheckedItems.Count;
            int iteratorNum = 0;

            for (int x = 0; x < numOfChecks; x++)
            {

                var product = productsInShoppingListBox.CheckedItems;
                var output = db.GetProducts();
                int listIndex = productsInShoppingListBox.Items.IndexOf(product);
                Console.WriteLine(productsInShoppingListBox.Items.IndexOf(product));

                db.ClearChecked(output[(listIndex - listDecreasing)].Product.ToString());
                products = db.GetProducts();
                UpdateBinding();
                iteratorNum++;
            }*/

            foreach (var i in productsInShoppingListBox.CheckedItems)
            {
                var output = db.GetProducts();
                int listIndex = productsInShoppingListBox.Items.IndexOf(i);
                //Console.WriteLine(productsInShoppingListBox.Items.IndexOf(i));

                db.ClearChecked(output[(listIndex - listDecreasing)].Product.ToString());
                products = db.GetProducts();
                UpdateBinding();
                listDecreasing += 1;
            }
        }
    }
}
