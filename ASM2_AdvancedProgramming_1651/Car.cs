using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASM2_AdvancedProgramming_1651;

namespace ASM2_AdvancedProgramming_1651
{
    internal class Car : IInfor
    {
        private int id;
        private string brand;
        private string _model;
        private double price;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                bool containsInt = value.Any(char.IsDigit);
                if (containsInt)
                {
                    throw new ArgumentException("!!! Brand not valid !!!");

                }
                brand = value;
            }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public virtual double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Car(int id, string brand, string _model, double price)
        {
            Id = id;
            Brand = brand;
            Model = _model;
            Price = price;

        }

        public string PrintInfor()
        {
            var st = new StringBuilder();
            st.Append($"Type: {this.GetType().Name} | ID: {this.Id} | Brand: {this.Brand} | Model: {this.Model} | Price: ${this.Price}\n");

            return st.ToString();
        }
    }
}
