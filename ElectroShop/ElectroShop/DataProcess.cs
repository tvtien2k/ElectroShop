using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ElectroShop
{
    public class DataProcess
    {
        public SqlConnection GetConnection()
        {
            SqlConnection conn = null;
            conn = new SqlConnection("SERVER=TVTIEN\\SQLEXPRESS; Database=ElectroShop; User Id = sa; pwd =123456");
            return conn;
        }

        //ham dang nhap
        public Staff CheckLogin(string u, string p)
        {
            Staff lg = null;
            string sql = "select * from tblStaff where Staff_user=@u and Staff_pass=@p";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Parameters.AddWithValue("@u", u);
            cmd.Parameters.AddWithValue("@p", p);
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                lg = new Staff();
                lg.User = u;
                lg.Pass = p;
                lg.Power = rd.GetString(3);
            }
            rd.Close();
            cmd.Connection.Close();
            return lg;
        }
        /// <summary>
        /// Supplier
        /// </summary>
        //ham them va hien thi Supplier
        public DataTable AddSupplier(string id, string name, string cmt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddSupplier";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@cmt", cmt);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            cmd.Connection.Close();
            return dt;
        }
        //ham hien thi Supplier
        public DataTable GetSupplier()
        {
            string sql = "select * from tblSupplier";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //ham sua va hien thi Supplier
        public DataTable EditSupplier(string id, string name, string cmt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EditSupplier";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@cmt", cmt);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            cmd.Connection.Close();
            return dt;
        }
        //ham tim kiem supplier
        public DataTable SearchSupplier(string id)
        {
            string sql = "select Supplier_id, Supplier_name, cmt from tblSupplier where Supplier_id=@id";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            return dt;
        }
        //ham xoa supplier
        public bool DeleteSupplier(string id)
        {
            string sql = "delete from tblSupplier where Supplier_id=@id";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        /// <summary>
        /// Category
        /// </summary>
        //ham them va hien thi Category
        public DataTable AddCategory(string id, string name, string cmt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddCategory";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@cmt", cmt);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            cmd.Connection.Close();
            return dt;
        }
        //ham hien thi Category
        public DataTable GetCategory()
        {
            string sql = "select * from tblCategory";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //ham sua va hien thi Category
        public DataTable EditCategory(string id, string name, string cmt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EditCategory";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@cmt", cmt);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            cmd.Connection.Close();
            return dt;
        }
        //ham tim kiem category
        public DataTable SearchCategory(string id)
        {
            string sql = "select Category_id, Category_name, cmt from tblCategory where Category_id=@id";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            return dt;
        }
        //ham xoa category
        public bool DeleteCategory(string id)
        {
            string sql = "delete from tblCategory where Category_id=@id";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        /// <summary>
        /// Product
        /// </summary>
        //ham hien thi ten Supplier ra combobox theo id (tren form add product)
        public List<Supplier> ListSuppliers()
        {
            string sql = "select * from tblSupplier";
            List<Supplier> list = new List<Supplier>();
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Supplier s = new Supplier();
                s.ID = rd.GetString(0);
                s.Name = rd.GetString(1);
                list.Add(s);
            }
            rd.Close();
            cmd.Connection.Close();
            return list;
        }
        //ham hien thi ten Category ra combobox theo id (tren form add product)
        public List<Category> ListCategorys()
        {
            string sql = "select * from tblCategory";
            List<Category> list = new List<Category>();
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                Category c = new Category();
                c.ID = rd.GetString(0);
                c.Name = rd.GetString(1);
                list.Add(c);
            }
            rd.Close();
            cmd.Connection.Close();
            return list;
        }
        //ham them product
        public bool AddProduct(string id, string name, string supplier, string category, float p_in, float p_out, string img, string cmt)
        {
            string sql = "insert into tblProduct values (@id,@n,@s,@c,@pi,@po,@img,@cmt)";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@s", supplier);
            cmd.Parameters.AddWithValue("@c", category);
            cmd.Parameters.AddWithValue("@pi", p_in);
            cmd.Parameters.AddWithValue("@po", p_out);
            cmd.Parameters.AddWithValue("@img", img);
            cmd.Parameters.AddWithValue("@cmt", cmt);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        //ham show danh sach product
        public DataTable ShowProducts()
        {
            string sql = "select Product_id, Product_name, price_in, price_out, cmt from tblProduct";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //ham tim kiem product
        public DataTable SearchP(string id)
        {
            string sql = "select Product_id, Product_name, price_in, price_out, cmt from tblProduct where Product_id=@id";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            return dt;
        }
        //ham tim kiem product chi tiet
        public DataTable SearchDetailedProduct(string id)
        {
            string sql = "SELECT tblProduct.Product_id, tblProduct.Product_name, tblSupplier.Supplier_name, tblCategory.Category_name FROM tblProduct JOIN tblSupplier ON tblProduct.Supplier_id = tblSupplier.Supplier_id JOIN tblCategory ON tblProduct.Category_id = tblCategory.Category_id where tblProduct.Product_id = @id";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            return dt;
        }
        //ham xoa product
        public bool DeleteProduct(string id)
        {
            string sql = "delete from tblProduct where Product_id=@id";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }
        //ham sua va hien thi Product
        public DataTable EditProduct(string id, string p_in, string p_out, string cmt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EditProduct";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@p_in", p_in);
            cmd.Parameters.AddWithValue("@p_out", p_out);
            cmd.Parameters.AddWithValue("@cmt", cmt);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            cmd.Connection.Close();
            return dt;
        }
        /// <summary>
        /// Staff
        /// </summary>
        //Ham them va hien thi Staff
        public DataTable AddStaff(string user, string pass, string name, string power, string sex, string add, string phone, DateTime birthday, string cmt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = GetConnection();
            cmd.Connection.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AddStaff";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@power", power);
            cmd.Parameters.AddWithValue("@sex", sex);
            cmd.Parameters.AddWithValue("@add", add);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@birthday", birthday);
            cmd.Parameters.AddWithValue("@cmt", cmt);
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            cmd.Connection.Close();
            return dt;
        }
        //ham show danh sach Staff
        public DataTable ShowStaff()
        {
            string sql = "select Staff_user, Staff_name, sex, Staff_address, phone_number, birthday, cmt from tblStaff";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //ham tim kiem staff
        public DataTable SearchStaff(string id)
        {
            string sql = "select Staff_user, Staff_name, sex, Staff_address, phone_number, birthday, cmt from tblStaff where Staff_user=@id";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// bill
        /// </summary>
        //Ham tim kiem Product theo ID
        public Product SearchProduct(string id)
        {
            Product sp = null;
            string sql = "select Product_id, Product_name, price_out from tblProduct where Product_id=@id";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                sp = new Product();
                sp.ID = id;
                sp.Name = rd.GetString(1);
                sp.POut = (float)rd.GetDouble(2);
            }
            rd.Close();
            cmd.Connection.Close();
            return sp;
        }
        //ham them Bill
        public bool AddBill(string b_id, string s_id, string cus_name, string cus_phone, string email, string add, float total, string cmt,DataTable dt)
        {
            string sql = "insert into tblBill(Bill_id,Staff_id,Customer,phone_customer,email,_add,total_cost,cmt) values (@b_id,@s_id,@cus_name,@cus_phone,@email,@add,@total,@cmt)";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@b_id", b_id);
            cmd.Parameters.AddWithValue("@s_id", s_id);
            cmd.Parameters.AddWithValue("@cus_name", cus_name);
            cmd.Parameters.AddWithValue("@cus_phone", cus_phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@add", add);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@cmt", cmt);
            int r1 = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            int r2 = 0;
            foreach (DataRow item in dt.Rows)
            {
                sql = "insert into tblDetailedBill values(@b_id,@p_id,@number,@price)";
                SqlCommand cmd1 = new SqlCommand(sql, GetConnection());
                cmd1.Connection.Open();
                //cart.Columns.Add(new DataColumn("_id", typeof(string)));
                //cart.Columns.Add(new DataColumn("_name", typeof(string)));
                //cart.Columns.Add(new DataColumn("_q", typeof(int)));
                //cart.Columns.Add(new DataColumn("_price", typeof(float)));
                //DataColumn col = new DataColumn("_total", typeof(float));
                cmd1.Parameters.AddWithValue("@b_id", b_id);
                cmd1.Parameters.AddWithValue("@p_id", item[0].ToString());
                cmd1.Parameters.AddWithValue("@number", item[2].ToString());
                cmd1.Parameters.AddWithValue("@price", item[3].ToString());
                r2 += cmd1.ExecuteNonQuery();
                cmd1.Connection.Close();
            }
            return (r1 > 0) && (r2 > 0);
        }
        //ham show danh sach bill
        public DataTable ShowBill()
        {
            string sql = "select Bill_id, Invoice_date, Staff_name, Customer, phone_customer, email, _add, total_cost from tblBill, tblStaff where tblBill.Staff_id = tblStaff.Staff_user";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //ham tim kiem Bill
        public DataTable SearchBill(string id)
        {
            string sql = "select Bill_id, Invoice_date, Staff_name, Customer, phone_customer, email, _add, total_cost from tblBill, tblStaff where tblBill.Staff_id = tblStaff.Staff_user and Bill_id=@id";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            return dt;
        }
        //ham tim kiem Bill chi tiet
        public DataTable SearchDetailedBill(string id)
        {
            string sql = "SELECT tblProduct.Product_id, tblProduct.Product_name, tblDetailedBill.number, tblDetailedBill.price_current FROM tblBill JOIN tblDetailedBill ON tblBill.Bill_id = tblDetailedBill.Bill_id JOIN tblProduct ON tblDetailedBill.Product_id = tblProduct.Product_id where tblBill.Bill_id = @id";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            return dt;
        }
        //ham xoa Bill
        public bool DeleteBill(string id)
        {
            string sql = "delete from tblDetailedBill where Bill_id=@id delete from tblBill where Bill_id=@id";
            SqlCommand cmd = new SqlCommand(sql, GetConnection());
            cmd.Connection.Open();
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result > 0;
        }

        /// <summary>
        /// other
        /// </summary>

        //ham show mail
        public DataTable ShowMail()
        {
            string sql = "select Customer, email from tblBill";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //ham report theo thoi gian
        public DataTable ReportTime(string fromDate, string toDate)
        {
            string sql = "select Bill_id, Invoice_date, Customer, phone_customer, email, _add, total_cost, cmt from tblBill where Invoice_date between @f and @t";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@f", fromDate);
            da.SelectCommand.Parameters.AddWithValue("@t", toDate);
            da.Fill(dt);
            return dt;
        }
        //ham report theo id nhan vien
        public DataTable ReportStaff(string id)
        {
            string sql = "select Bill_id, Invoice_date, Customer, phone_customer, email, _add, total_cost, cmt from tblBill where Staff_id=@id";
            SqlDataAdapter da = new SqlDataAdapter(sql, GetConnection());
            DataTable dt = new DataTable();
            da.SelectCommand.Parameters.AddWithValue("@id", id);
            da.Fill(dt);
            return dt;
        }
    }
}
