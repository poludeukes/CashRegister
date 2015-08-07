using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace kasszaprogram
{
    class CashStockRegister
    {
        public CashStockRegister()
        {
            actual_amount.Add("mentesviz", 0);
            actual_amount.Add("savasviz", 0);
        }

        string path = @"../../Prices/pricelist.csv";        
        //  valami elelnőrzés kell majd a path-beállításhoz, ha már nem manuális lesz, valami ilyesmi:
        //  if (File.Exists(path))   { set path }    

        private Dictionary<string, int> actual_amount = new Dictionary<string, int>();     
        private int _sum_money = 0;

        public int sum_money
        {
            get { return _sum_money; }
        }

        private void FillDictionaryFromCSV()
        {
            // string[] csvText = Properties.Resources.pricelist.Split('\n');
            // foreach (string s in csvText)
            // {
            //     Console.WriteLine(s);
            // }
            // var reader = new StreamReader(File.OpenRead(@"C:\test.csv"));

            var reader = new StreamReader(File.OpenRead(Properties.Resources.pricelist));
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                string productname = values[0];
                int whichprice = Convert.ToInt32(values[1]);
                int activeprice = Convert.ToInt32(values[whichprice + 2]);

                AddNewDictionaryMember(productname, activeprice, 0);
            }
            
            
            // List<string> listA = new List<string>();
            // List<string> listB = new List<string>();
            // while (!reader.EndOfStream)
            // {
            //     var line = reader.ReadLine();
            //     var values = line.Split(';');
            // 
            //     listA.Add(values[0]);
            //     listB.Add(values[1]);
            // }
        }

        public void AddNewProduct(string productName, int price, int startAmount)
        {
            bool repeat = false;

            // check if it's an existing item in csv or in dictionary            
            using (StreamReader reader = new StreamReader(File.OpenRead(path)))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    string csvProductName = values[0];

                    if (csvProductName == productName)
                    {
                        repeat = true;
                        break;
                    }
                    // else let cicle go further, leaving repeat 'false'
                }
            }
            // var reader = new StreamReader(File.OpenRead(path));

            // add new line to CSV if it is a new one
            if(repeat)
            {
                MessageBox.Show("ez a termék már szerepel a listában");
            }
            else
            {
                List<String> oldLines = new List<String>();
                
                using (StreamReader reader = new StreamReader(path))
                {
                    String line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        oldLines.Add(line);
                    }
                }
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    for (int i = 0; i < oldLines.Count; i++)
                    {
                        writer.WriteLine(oldLines[i]);
                    }

                    string newline = productName + "; " + price.ToString() + "; " + startAmount.ToString();
                    writer.WriteLine(newline);
                }

                // refresh Dictionary from CSV
                RefreshDictionaryMembers();

                // send OK message
                MessageBox.Show("hozzáadva");
            }        
        }

        /// <summary>
        /// Refreshes Dictionary members from CSV source file
        /// </summary>
        public void RefreshDictionaryMembers()
        {
            this.actual_amount.Clear();

            var reader = new StreamReader(File.OpenRead(path));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                string productname = values[0];
                int whichprice = Convert.ToInt32(values[1]);
                int activeprice = Convert.ToInt32(values[whichprice + 1]);

                AddNewDictionaryMember(productname, activeprice, 0);
            }
        }

        public void AddNewDictionaryMember(string productName, int price, int startAmount)
        {
            actual_amount.Add(productName, startAmount);
        }

        /// <summary>
        /// Delete product from the member dictionary, so it will be invisible in the form, but still existing in the CSV
        /// </summary>
        /// <param name="toBeRemoved"></param>
        public void RemoveProduct(string toBeRemoved)
        {
            throw new NotImplementedException("removeproduct");
        }

        public void ChangePrice(string toBeChanged, int newPrice)
        {
            throw new NotImplementedException("changeprice");
        }
        
        public void ChangeProductName(string toBeChanged, string newName)
        {
            throw new NotImplementedException("changeproductname");
        }
    }
}