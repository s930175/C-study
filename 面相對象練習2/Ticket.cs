using System;
using System.Collections.Generic;
using System.Text;

namespace 面相對象練習2
{
    public class Ticket
    {
        private double _distance;
        public double Distance//唯讀
        {
            get { return _distance; }
        }

        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            //不可寫this.Distance = distance，因其為唯讀，只可讀不可寫(沒有set)
            this._distance = distance;
        }

        private double _price;//唯讀
        public double Price//唯讀
        {
            get {
                if (_distance > 0 && _distance <= 100)
                {
                    return _distance * 1.0;
                }
                else if (_distance >= 101 && _distance <= 200)
                {
                    return _distance * 0.95;
                }
                else if (_distance >= 201 && _distance <= 300)
                {
                    return _distance * 0.9;
                }
                else
                {
                    return _distance * 0.8;
                }
                /*return _price;*/ 
            }
        }

        public void ShowTicket()
        {
            Console.WriteLine("{0}公里需要{1}元", this.Distance, this.Price);
        }
    }
}
