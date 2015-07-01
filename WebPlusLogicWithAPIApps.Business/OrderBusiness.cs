using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPlusLogicWithAPIApps.Entity;

namespace WebPlusLogicWithAPIApps.Business
{
    public class OrderBusiness
    {
        public BusinessResult Create(OrderEntity orderEntity)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter() { ParameterName = "@RecipientName", SqlValue=orderEntity.RecipientName });
            paramList.Add(new SqlParameter() { ParameterName = "@DeliveryStreet", SqlValue = orderEntity.DeliveryStreet });
            paramList.Add(new SqlParameter() { ParameterName = "@DeliveryCity", SqlValue = orderEntity.DeliveryCity });
            paramList.Add(new SqlParameter() { ParameterName = "@DeliveryState", SqlValue = orderEntity.DeliveryState });
            paramList.Add(new SqlParameter() { ParameterName = "@DeliveryPostalCode", SqlValue = orderEntity.DeliveryPostalCode });
            paramList.Add(new SqlParameter() { ParameterName = "@Phone", SqlValue = orderEntity.Phone});

            int result = SqlHelper.ExecuteNonQuery(DBConnection.ConnectionString,System.Data.CommandType.StoredProcedure,"usp_CreateOrder",paramList.ToArray());
            
            return new BusinessResult(){ISuccess=true,Code="S",Message="Order Created Successfully."};
        }
    }
}
