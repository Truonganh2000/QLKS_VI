using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLKS
{
    class connection
    {
        public string strConn = @"Data Source=DESKTOP-4IIGFPI\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True";
        public SqlConnection conn { get; set; }
        public SqlCommand cmd { get; set; } 
        public SqlDataReader drd { get; set; } 
        public SqlDataAdapter da { get; set; } 
        public connection() {
            conn = new SqlConnection(strConn); 
            cmd = null; 
            drd = null;
            da = null;
        }
        
        public bool openConn() { 
            try { conn.Open(); 
                return true;
            } catch (Exception) 
            { return false;
            } 
        } 
        //Đóng kết nối đến nguồn dữ liệu 
        public bool closeConn() { 
            try { conn.Close();
                return true; 
            } catch (Exception) { 
                return false; 
            } 
        }        
        ////Mô hình kết nối////       
        ///
        //Đổ dữ liệu từ CSDL -> DataReader -> Client đọc     
        public SqlDataReader executeSQL(string sql)         {  
            cmd = new SqlCommand(sql, conn);      
            drd = cmd.ExecuteReader();         
            return drd;
        }         //Cập nhật dữ liệu theo mô hình kết nối       
        public int executeUpdate(string sql)         {       
            cmd = new SqlCommand(sql, conn);          
            return cmd.ExecuteNonQuery();       
        }         ////Mô hình ngắt kết nối/////        
        //Đổ dữ liệu từ CSDL -> DataAdapter -> DataTable (DataSet-Client)   
        public DataTable loadDataTable(string sql)         {    
            cmd = new SqlCommand(sql, conn);       
            da = new SqlDataAdapter(cmd);          
            DataTable dt = new DataTable();        
            da.Fill(dt);           
            return dt;       
        }         //Cập nhật dữ liệu từ DataTable vào CSDL qua DataAdapter (tương đồng bảng)        
        public void UpdateTable(DataTable dt)         {       
            SqlCommandBuilder scb = new SqlCommandBuilder(da);    
            da.Update(dt); 
        }         
    } 


    }
