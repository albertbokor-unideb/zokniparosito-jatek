using Microsoft.Extensions.Configuration;
using MySqlConnector;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace zokniParosito.Database
{

    public class DatabaseService
    {
        private readonly IConfiguration _configuration;

        public DatabaseService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private MySqlConnection CreateConnection()
        {
            string connectionString = _configuration.GetConnectionString("Default");
            return new MySqlConnection(connectionString);
        }

        public async Task<string> QueryToJsonAsync<T>(string sqlQuery) where T : class, new()
        {
            try
            {
                using var connection = CreateConnection();
                await connection.OpenAsync();

                using var command = new MySqlCommand(sqlQuery, connection);
                using var reader = await command.ExecuteReaderAsync();

                var data = new List<T>();

                while (await reader.ReadAsync())
                {
                    var item = new T();

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        var propertyName = reader.GetName(i);
                        var propertyInfo = typeof(T).GetProperty(propertyName);

                        if (propertyInfo != null)
                        {
                            var value = reader.GetValue(i);
                            propertyInfo.SetValue(item, value is DBNull ? null : value, null);
                        }
                    }

                    data.Add(item);
                }

                var json = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
                return json;
            }
            catch (Exception ex)
            {
                throw new Exception("Adatbázis lekérdezés hiba", ex);
            }
        }

        public async Task<bool> ExecuteNonQueryAsync(string sqlQuery)
        {
            try
            {
                using var connection = CreateConnection();
                await connection.OpenAsync();

                using var command = new MySqlCommand(sqlQuery, connection);
                int rowsAffected = await command.ExecuteNonQueryAsync();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Adatbázis művelet hiba", ex);
            }
        }
    }
}
