using Bai05.Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite; // Thư viện vừa cài
using System.IO;

public class DatabaseHelper
{
    private const string DbName = "StudentManagement.sqlite";
    private string _connectionString;

    public DatabaseHelper()
    {
        _connectionString = $"Data Source={DbName};Version=3;";
        InitializeDatabase();
    }

    // 1. Tạo file DB và Bảng nếu chưa có
    private void InitializeDatabase()
    {
        if (!File.Exists(DbName))
        {
            SQLiteConnection.CreateFile(DbName);
        }

        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string sql = @"
                CREATE TABLE IF NOT EXISTS Students (
                    ID TEXT PRIMARY KEY,
                    Name TEXT NOT NULL,
                    Faculty TEXT,
                    Score REAL
                )";
            using (var command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
    public void AddStudent(Student s)
    {
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string sql = "INSERT INTO Students (ID, Name, Faculty, Score) VALUES (@id, @name, @faculty, @score)";
            using (var command = new SQLiteCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", s.MSSV);
                command.Parameters.AddWithValue("@name", s.TenSV);
                command.Parameters.AddWithValue("@faculty", s.Khoa);
                command.Parameters.AddWithValue("@score", s.DiemTB);
                command.ExecuteNonQuery();
            }
        }
    }
    public List<Student> GetAllStudents()
    {
        var list = new List<Student>();
        using (var connection = new SQLiteConnection(_connectionString))
        {
            connection.Open();
            string sql = "SELECT * FROM Students";
            using (var command = new SQLiteCommand(sql, connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new Student()
                    {
                        MSSV = reader["ID"].ToString(),
                        TenSV = reader["Name"].ToString(),
                        Khoa = reader["Faculty"].ToString(),
                        DiemTB = float.Parse(reader["Score"].ToString())
                    });
                }
            }
        }
        return list;
    }
}