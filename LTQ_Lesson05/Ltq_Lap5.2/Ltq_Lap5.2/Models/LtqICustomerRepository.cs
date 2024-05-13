using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ltq_Lap5._2.Models
{
    interface LtqICustomerRepository
    {
        //khai báo phương thức lấy danh sách khách hàng
        IList<LtqCustomer> GetCustomers();
        //khai báo phương thức lấy khách hàng
        LtqCustomer GetCustomer(string customerId);
        //khai báo phương thức thêm khách hàng
        void AddCustomer(LtqCustomer cus);
        //khai báo phương thức cập nhật khách hàng
        void UpdateCustomer(LtqCustomer cus);
        //khai báo phương thức tìm kiếm khách hàng
        IList<LtqCustomer> SearchCustomer(string name);
        //khai báo phương thức xóa khách hàng
        void DeleteCustomer(LtqCustomer cus);

    }
}
