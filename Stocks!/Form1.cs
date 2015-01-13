using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;

namespace Stocks_
{
    public partial class Form1 : Form
    {
             
        List<PointPairList> pointList = new List<PointPairList>();
        List<Stock> stocksList = new List<Stock>();

        
        double x = 0;
        int count = 0;
        double highestStock = 0;
        User user = new User("Lord Wimbley", 1000.00);



        public Form1()
        {
            InitializeComponent();

            CreateStock("Monkey Paws",5,100);
            CreateStock("Zombie corp", 20, 50);
            CreateStock("A turnip", .1, 300);

            foreach (Stock stock in stocksList)
            {
                stocksComboBx.Items.Add(stock.StockName);
            }

            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 800;
            t.Tick += new EventHandler(timer_Tick);
            t.Start();

            userNameBx.Text = user.UserName;

            zedGraph.GraphPane.YAxis.Scale.Min = -1;              
        }




        void timer_Tick(object sender, EventArgs e)
        {
            int stockNo;
            double rand;
            double totalValue = 0;
            double stockValue = 0;
            Random rnd = new Random();

            x += 0.2;

            zedGraph.GraphPane.XAxis.Scale.Max = x + 2;
            if (x > 10)
            {
                zedGraph.GraphPane.XAxis.Scale.Min = x - 7;
            }

            int i = 0;

            //Convert.ToInt16(stocksList.GetEnumerator().Current)

           foreach (Stock stock in stocksList)
            {
                
                rand = rnd.Next(-5,10);
                     
               
                pointList.ElementAt(i).Add(x, stock.StockValue + rand/10);
                stock.StockValue += rand/10;
                

                if (stock.StockValue + rand / 10 > highestStock)
               {
                   highestStock = stock.StockValue + rand / 10;
                   zedGraph.GraphPane.YAxis.Scale.Max = highestStock+2;
               }
                i++;
   
            }
             zedGraph.Invalidate();

            
             cashTxt.Text = user.Cash.ToString();


             foreach (KeyValuePair<string, double> userStock in user.portfolio)
             {

                stockValue = stocksList.Find(name => name.StockName.Equals(userStock.Key)).StockValue;
                totalValue += userStock.Value * stockValue;

             }
             stkValueTxt.Text = totalValue.ToString();


             if (stocksComboBx.SelectedItem != null)
             {
                 stockValue = stocksList.Find(name => name.StockName.Equals(stocksComboBx.SelectedItem.ToString())).StockValue;
                 stockNo = stocksList.Find(name => name.StockName.Equals(stocksComboBx.SelectedItem.ToString())).AvailableStocks;
                 totalStkValueTxt.Text = (stockValue * stockNo).ToString();

                 availSharesTxt.Text = stockNo.ToString();
             }

             

        }


       
        private void createBtn_Click_1(object sender, EventArgs e)
        {
            double shareValue;
            int numberOfShares;
   
            if (stkNameTxt.Text != "" && double.TryParse(shareVauleTxt.Text, out shareValue)
                && int.TryParse(numOfSharesTxt.Text, out numberOfShares))
            {
                CreateStock(stkNameTxt.Text, shareValue, numberOfShares);

                stocksComboBx.Items.Add(stkNameTxt.Text);
            }
            
        }




        private void CreateStock(string stockName, double stockValue, int availableStocks)
        {
            Stock stock = new Stock(stockName,stockValue,availableStocks);

            PointPairList pointPair = new PointPairList();
            pointList.Add(pointPair);

            LineItem myCurve = zedGraph.GraphPane.AddCurve(stock.StockName,
            pointList.ElementAt(count),
            Color.Blue, SymbolType.Diamond);

            count++;

            stocksList.Add(stock);
        }



        void createGraph()
        {
            ZedGraph.ZedGraphControl zeddo = new ZedGraph.ZedGraphControl();
            GraphPane myPane = new GraphPane();

            myPane = zeddo.GraphPane;

            myPane.Title.Text = "This is an example!";
            zeddo.AxisChange();
            zeddo.Location = new Point(500, 0);
            Controls.Add(zeddo);
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            int num;
            double stockValue;
            int stockNo;

            stockValue = stocksList.Find(name => name.StockName.Equals(stocksComboBx.SelectedItem.ToString())).StockValue;
            stockNo = stocksList.Find(name => name.StockName.Equals(stocksComboBx.SelectedItem.ToString())).AvailableStocks;
          

            if (int.TryParse(buyTxtBx.Text, out num) && user.Cash >= num * stockValue && num <= stockNo)
            {
                if (!user.portfolio.ContainsKey(stocksComboBx.SelectedItem.ToString()))
                {
                    user.portfolio.Add(stocksComboBx.SelectedItem.ToString(), num);
                }
                else
                {
                    user.portfolio[stocksComboBx.SelectedItem.ToString()] += num;
                }

                user.Cash -= num * stockValue;
                stocksList.Find(name => name.StockName.Equals(stocksComboBx.SelectedItem.ToString())).AvailableStocks = stockNo - num;
            }
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            int num;
            double stockValue;

            if (int.TryParse(sellTxtBx.Text, out num) && user.portfolio[stocksComboBx.SelectedItem.ToString()] >= num)
            {
                stockValue = stocksList.Find(name => name.StockName.Equals(stocksComboBx.SelectedItem.ToString())).StockValue;

                user.portfolio[stocksComboBx.SelectedItem.ToString()] -= num;

                user.Cash += num * stockValue;

                stocksList.Find(name => name.StockName.Equals(stocksComboBx.SelectedItem.ToString())).AvailableStocks += num;
            }
        }

        private void stocksComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    

    

    }
}