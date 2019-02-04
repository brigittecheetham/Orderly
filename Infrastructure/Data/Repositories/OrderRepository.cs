using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Core.Entities;
using Core.Interfaces;

namespace Infrastructure.Data.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {

        public OrderRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Order> OrdersByCustomerId(int customerId)
        {

            try
            {

                //    using (var command = _context.CreateCommand())
                //    {
                //        command.CommandText = "select Id, OrderDate, CustomerReference, Despatched from OrderHeader where CustomerId = @CustomerId";
                //        command.CommandType = CommandType.Text;


                //        var param = command.CreateParameter();
                //        param.ParameterName = "@CustomerId";
                //        param.Value = customerId;

                //        command.Parameters.Add(param);



                //    }



            }
            catch (Exception ex)
            {
                //add logging of exception when trying to read customers from db
            }


            return null;
            //foreach (DataRow row in table.Rows)
            //{
            //    yield return new OrderHeader
            //    {
            //        Id = Convert.ToInt32(row["Id"]),
            //        OrderDate = Convert.ToDateTime(row["OrderDate"]),
            //        CustomerReference = row["CustomerReference"].ToString(),
            //        Despatched = Convert.ToBoolean(row["Despatched"])
            //    };
            //}
        }

    }
}
