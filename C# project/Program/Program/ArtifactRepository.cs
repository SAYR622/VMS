using Microsoft.Data.SqlClient; // Handles your SQL Server connection
using System;
using System.Collections.Generic;

namespace Program
{
    public class ArtifactRepository
    {
        private readonly string _connectionString;

        // Constructor: This catches the connection string you pass from Program.cs
        public ArtifactRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // 1. CREATE: Insert a new artifact into your database table
        public void InsertArtifact(Artifact artifact)
        {
            string query = "INSERT INTO Artifacts (Title, Creator, YearCreated, Description) " +
                           "VALUES (@Title, @Creator, @YearCreated, @Description)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", artifact.Title);
                    command.Parameters.AddWithValue("@Creator", artifact.Creator);
                    command.Parameters.AddWithValue("@YearCreated", artifact.YearCreated);
                    command.Parameters.AddWithValue("@Description", artifact.Description);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 2. READ: Select and fetch all artifacts from your database table
        public List<Artifact> GetAllArtifacts()
        {
            List<Artifact> list = new List<Artifact>();
            string query = "SELECT Id, Title, Creator, YearCreated, Description FROM Artifacts";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Artifact
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Title = reader["Title"].ToString(),
                                Creator = reader["Creator"].ToString(),
                                YearCreated = Convert.ToInt32(reader["YearCreated"]),
                                Description = reader["Description"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        // 3. UPDATE: Edit an existing artifact's information
        public void UpdateArtifact(Artifact artifact)
        {
            string query = "UPDATE Artifacts SET Title = @Title, Creator = @Creator, " +
                           "YearCreated = @YearCreated, Description = @Description WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", artifact.Id);
                    command.Parameters.AddWithValue("@Title", artifact.Title);
                    command.Parameters.AddWithValue("@Creator", artifact.Creator);
                    command.Parameters.AddWithValue("@YearCreated", artifact.YearCreated);
                    command.Parameters.AddWithValue("@Description", artifact.Description);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        // 4. DELETE: Remove an artifact completely using its unique ID
        public void DeleteArtifact(int id)
        {
            string query = "DELETE FROM Artifacts WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}