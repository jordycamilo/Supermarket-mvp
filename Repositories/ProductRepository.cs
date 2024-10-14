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
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }


        public void Add(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
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

        public void PDelete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM PayMode WHERE Pay_Mode_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            }
        }

        public void PEdit(ProductModel productModel)
        {
            using (var connection = new SqlConnection(connectionString))
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

        public void Edit(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER BY Pay_Mode_Id DESC";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.PId = (int)reader["ProductId"];
                        productModel.PName = reader["ProductName"].ToString();
                        productModel.PObservation = reader["ProductObservation"].ToString();
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> PGetByValue(string Pvalue)
        {
            var productList = new List<ProductModel>();
            int productId = int.TryParse(Pvalue, out var id) ? id : 0;
            string productName = Pvalue;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Abre la conexión

                using (var command = new SqlCommand())
                {
                    command.Connection = connection; // Asigna la conexión al comando
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
                                PName = reader["ProductName"].ToString(), // Asegúrate que este nombre sea correcto
                                PObservation = reader["productObservation"].ToString()
                            };
                            productList.Add(productModel);
                        }
                    }
                }
            }
            return productList;
        }

        IEnumerable<ProductModel> IProductRepository.PGetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<ProductModel> IProductRepository.PGetByValue(string Pvalue)
        {
            throw new NotImplementedException();
        }
    }
}
