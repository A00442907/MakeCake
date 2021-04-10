using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeMake.Models
{
    public class Transaction
    {
        private readonly AppDbContext _appDbContext;
        public string PaymentId { get; set; }

        public Transaction(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static Transaction GetTransaction(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            String transId = session.GetString("PaymentId") ?? Guid.NewGuid().ToString();
            session.SetString("PaymentId", transId);

            return new Transaction(context) { PaymentId = transId};
        }
    }
}
