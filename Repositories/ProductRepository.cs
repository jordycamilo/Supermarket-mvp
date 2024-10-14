using Supermarket_mvp.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_mvp.Models;
using System.Data;



namespace Supermarket_mvp.Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString1)
        {
            this.connectionString1 = connectionString1;
        }


        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection (connectionString1))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO PayMode VALUES (@name, @observation)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.PName;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productModel.PObservation;
                command.ExecuteNonQuery();
            }
        }

        public void PAdd(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public void PDelete(int Pid)
        {
            using (var connection = new SqlConnection(connectionString1))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM PayMode WHERE Pay_Mode_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = Pid;
                command.ExecuteNonQuery();
            }
        }

        public void PEdit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString1))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE PayMode
                             SET Pay_Mode_Name = @name,
                                 Pay_Mode_Observation = @observation
                             WHERE Pay_Mode_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.PName;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = productModel.PObservation;
                command.Parameters.Add("@id", SqlDbType.Int).Value = productModel.PId;
                command.ExecuteNonQuery();
            }
        }



        public IEnumerable<ProductModel> PGetAll()
        {
            var productList = new List<ProductModel>();

            try
            {
                using (var connection = new SqlConnection(connectionString1))
                {
                    connection.Open();
                    using (var command = new SqlCommand("SELECT * FROM Product ORDER BY ProductId DESC", connection)) // Asegúrate de usar la columna correcta
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var productModel = new ProductModel
                                {
                                    PId = (int)reader["ProductId"],
                                    PName = reader["ProductName"].ToString(),
                                    PObservation = reader["ProductObservation"].ToString()
                                };
                                productList.Add(productModel);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
                Console.WriteLine("Error al obtener productos: " + ex.Message);
            }

            return productList;
        }


        public IEnumerable<ProductModel> PGetByValue(string Pvalue)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(Pvalue, out var id) ? id : 0;
            string productName = Pvalue;

            using (var connection = new SqlConnection(connectionString1))
            {
                connection.Open(); 

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM PayMode
                                    WHERE (@id = 0 OR Pay_Mode_Id = @id) 
                                    OR Pay_Mode_Name LIKE @name + '%'
                                    ORDER BY Pay_Mode_Id DESC";

                    command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var productModel = new ProductModel
                            {
                               PId = (int)reader["ProductId"],
                                PName = reader["ProductName"].ToString(), 
                                PObservation = reader["productObservation"].ToString()
                            };
                            productList.Add(productModel);
                        }
                    }
                }
            }
            return productList;
        }
       
    }
}
