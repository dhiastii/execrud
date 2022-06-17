using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execrud
{
    public class database
    { 
        public void updatedataAnggota(string id_anggota,string nama_anggota, string asal_anggota, string tahun_anggota)
        {
            string connectionString = GetConnectionString();
            string queryAnggota1 = $"select * from dataAnggota where Id_Anggota= '{id_anggota}'";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmdAnggota1 = new SqlCommand(queryAnggota1, cn); cn.Open();
                using (SqlDataReader drAnggota = cmdAnggota1.ExecuteReader())
                {
                    while (drAnggota.Read())
                    {
                        string queryAnggota2 = $"update dataAnggota SET NamaAnggota = '{nama_anggota}'," +
                            $" AsalKota = '{asal_anggota}', TahunBergabung = '{tahun_anggota}' WHERE Id_Anggota = '{id_anggota}'";
                        SqlCommand cmdAnggota2 = new SqlCommand(queryAnggota2, cn);
                        cmdAnggota2.ExecuteNonQuery();
                        Console.WriteLine("Data has been updated");
                    }
                }
            }
            Console.ReadLine();
        }

        public void updatedataAnggota()
        {
            throw new NotImplementedException();
        }

        public void updatedataAdmin(string id_admin, string nama_admin, string asal_admin, string notelepon_admin, string tahun_admin)
        {
            string connectionString = GetConnectionString();
            string queryAdmin1 = $"select * from dataAdmin where Id_Admin= '{id_admin}'";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmdAdmin1 = new SqlCommand(queryAdmin1, cn); cn.Open();
                using (SqlDataReader drAdmin = cmdAdmin1.ExecuteReader())
                {
                    while (drAdmin.Read())
                    {
                        string queryAdmin2 = $"update dataAdmin SET NamaAdmin = '{nama_admin}', AsalKota = '{asal_admin}', TahunBergabung = '{tahun_admin}', NoTelepon = '{notelepon_admin}' WHERE Id_Admin = '{id_admin}'";
                        SqlCommand cmdAdmin2 = new SqlCommand(queryAdmin2, cn);
                        cmdAdmin2.ExecuteNonQuery();
                        Console.WriteLine("Data has been updated");
                    }
                }
            }
            Console.ReadLine();
        }

        public void updatedataBuku(string id_buku, string judul_buku, string namapengarang, string tahun_buku)
        {
            string connectionString = GetConnectionString();
            string queryAnggota1 = $"select * from dataAnggota where Id_Buku= '{id_buku}'";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmdAnggota1 = new SqlCommand(queryAnggota1, cn); cn.Open();
                using (SqlDataReader drAnggota = cmdAnggota1.ExecuteReader())
                {
                    while (drAnggota.Read())
                    {
                        string queryAnggota2 = $"update dataAnggota SET JudulAnggota = '{judul_buku}', NamaPengarang = '{namapengarang}', TahunTerbit = '{tahun_buku}' WHERE Id_Buku = '{id_buku}'";
                        SqlCommand cmdAnggota2 = new SqlCommand(queryAnggota2, cn);
                        cmdAnggota2.ExecuteNonQuery();
                        Console.WriteLine("Data has been updated");
                    }
                }
            }
            Console.ReadLine();
        }
        public void deletedataAnggota(string id_anggota)
        {
            string connectionString = GetConnectionString();
            string query1 = $"select * from dataAnggota where Id_Anggota = '{id_anggota}'";
            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                SqlCommand cmd1 = new SqlCommand(query1, cn); cn.Open();
                using (SqlDataReader dr1 = cmd1.ExecuteReader())
                {
                    while (dr1.Read())
                    {
                        string query2 = $"delete dataAnggota WHERE Id_Anggota = '{id_anggota}'";
                        SqlCommand cmd2 = new SqlCommand(query2, cn);
                        cmd2.ExecuteNonQuery();
                        Console.WriteLine("Data has been deleted");
                    }
                }
            }
            Console.ReadLine();
        }

        private static string GetConnectionString()
        {
            return "data source = DESKTOP-H6RQMOI;database = execrud; MultipleActiveResultSets = True; User ID=sa; Password = 123";
        }
    }
}
