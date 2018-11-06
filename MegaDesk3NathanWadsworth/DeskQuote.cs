using System;
using System.IO;

namespace MegaDesk4NathanWadsworth
{
    public class DeskQuote
    {
        public double price = 200;
        public int RushOrder { get; set; }
        public string CustomerName { get; set; }
        public Desk Desk { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public Double Price { get; set; }

        public string GetQuote(Desk desk)
        {
            double area = desk.Width * desk.Height;
            int rush = this.RushOrder;
            int addedDays = 0;
            DateTime date = new DateTime();
            date = DateTime.Now;

            var csvInput = date.ToString("MM/dd/yyyy") + "," +
                this.CustomerName + "," + desk.Height + "," +
                desk.Width + "," + desk.NumberOfDrawers+",";
            if ((desk.Width*desk.Height) > 1000)
            {
                price += (area - 1000);
            }
            price += (desk.NumberOfDrawers * 50);
            switch (desk.Material)
            {
                case Desk.DesktopMaterial.Laminate:
                    price += 100;
                    csvInput += "Laminate,";
                    break;
                case Desk.DesktopMaterial.Oak:
                    price += 200;
                    csvInput += "Oak,";
                    break;
                case Desk.DesktopMaterial.Rosewood:
                    price += 300;
                    csvInput += "RoseWood,";
                    break;
                case Desk.DesktopMaterial.Veneer:
                    price += 125;
                    csvInput += "Veneer,";
                    break;
                case Desk.DesktopMaterial.Pine:                   
                    price += 50;
                    csvInput += "Pine,";
                    break;
                default:
                    break;
            }
            switch (rush)
            {
                case 1:
                    addedDays += 3;
                    if (area < 1000)
                    {
                        price += 60;
                    }
                    else if (area >= 1000 && area <= 2000)
                    {
                        price += 70;
                    }
                    else
                    {
                        price += 80;
                    }
                    addedDays = 3;
                    csvInput += "3 Days,";
                    break;
                case 2:
                    addedDays += 5;
                    if (area < 1000)
                    {
                        price += 40;
                    }
                    else if (area >= 1000 && area <= 2000)
                    {
                        price += 50;
                    }
                    else
                    {
                        price += 60;
                    }
                    addedDays = 5;
                    csvInput += "5 Days,";
                    break;
                case 3:
                    addedDays += 7;
                    if (area < 1000)
                    {
                        price += 30;
                    }
                    else if (area >= 1000 && area <= 2000)
                    {
                        price += 35;
                    }
                    else
                    {
                        price += 40;
                    }
                    addedDays = 7;
                    csvInput += "7 Days,";
                    break;

                default:
                    csvInput += "None,";
                    break;
            }
            DateTime dueDate = new DateTime();
            dueDate = date.AddDays(addedDays);

            csvInput += price + "," + dueDate.ToString("MM/dd") + Environment.NewLine;
          
            File.AppendAllText(@".\data.csv", csvInput);

            this.Price = price;
            return price.ToString();

        }
        

    }
}
 
