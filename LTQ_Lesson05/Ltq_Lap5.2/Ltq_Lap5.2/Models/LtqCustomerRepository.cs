using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ltq_Lap5._2.Models
{
    //định nghĩa lớp CustomerRepository thực thi từ giao diện ICustomerRepository

    public class LtqCustomerRepository:LtqICustomerRepository
    {
        //khởi tạo danh sách khách hàng
        static readonly List<LtqCustomer> data = new List<LtqCustomer>()
        {
          new LtqCustomer()
          {
                  CustomerId = "KH001",
                  FullName = "Trịnh Văn Chung",
                  Address = "Hà Nội",
                  Email = "devmaster.founder@gmail.com",
                  Phone = "0978.611.889",
                  Balance = 15200000
          },
          new LtqCustomer()
          {
                  CustomerId = "KH002",
                  FullName = "Đỗ Thị Cúc",
                  Address = "Hà Nội",
                  Email = "cucdt@gmail.com",
                  Phone = "0986.767.444",
                  Balance = 2200000
          },
          new LtqCustomer()
          {       CustomerId = "KH003",
                  FullName = "Nguyễn Tuấn Thắng",
                  Address = "Nam Định",
                  Email = "thangnt@gmail.com",
                  Phone = "0924.656.542",
                  Balance = 1200000
          },
          new LtqCustomer()
          {
                  CustomerId = "KH004",
                  FullName = "Lê Ngọc Hải",
                  Address = "Hà Nội",
                  Email = "hailn@gmail.com",
                  Phone = "0996.555.267",
                  Balance = 6200000}
          };
        //thực thi phương thức lấy danh sách khách hàng
        public IList<LtqCustomer> GetCustomers()
        {
            return data;
        }
        //thực thi phương thức tìm khách hàng theo tên
        public IList<LtqCustomer> SearchCustomer(string name)
        {
            return data.Where(c => c.FullName.EndsWith(name)).ToList();
        }
        //thực thi phương thức lấy khách hàng theo Id
        public LtqCustomer GetCustomer(string customerId)
        {
            return data.FirstOrDefault(c => c.CustomerId.Equals(customerId));
        }
        //thực thi phương thức thêm khách hàng
        public void AddCustomer(LtqCustomer cus)
        {
            data.Add(cus);
        }
        //thực thi phương thức cập nhật khách hàng
        public void UpdateCustomer(LtqCustomer cus)
        {
            //lấy khách hàng theo id
            var customer = data.FirstOrDefault(c =>
            c.CustomerId.Equals(cus.CustomerId));
            //nếu có thì sửa thông tin
            if (customer != null)
            {
                customer.FullName = cus.FullName;
                customer.Address = cus.Address;
                customer.Email = cus.Email;
                customer.Phone = cus.Phone;
                customer.Balance = cus.Balance;
            }
        }

        //thực thi phương thức xóa khách hàng
        public void DeleteCustomer(LtqCustomer cus)
        {
            data.Remove(cus);
        }
    }

}