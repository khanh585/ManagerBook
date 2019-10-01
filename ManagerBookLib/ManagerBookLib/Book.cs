using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerBookLib
{
    public class Book
    {
        private string id;









        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value.Trim().Length > 0)
                {
                    id = value;
                }

            }
        }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Trim().Length > 0)
                    name = value;
            }
        }

        private string publisher;
        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                if (value.Trim().Length > 0)
                    publisher = value;
            }
        }

        private float price;
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }

            }
        }


        public Book(string id, string name, string publisher, float price)
        {
            this.id = id;
            this.name = name;
            this.publisher = publisher;
            this.price = price;
        }

        public Book()
        {
        }

        public string toString()
        {
            return string.Format("{0,-20} | {1,-20} | {2,-20} | {3,-20}", id, name, publisher, price);
        }

    }
}
