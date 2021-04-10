using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeMake.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);

        void CreateOrder(Payment payment);
    }
}
