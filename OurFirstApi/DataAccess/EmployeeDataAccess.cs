﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using Dapper;
using OurFirstApi.Models;

namespace OurFirstApi.DataAccess
{

    public class EmployeeDataAccess : IRepository<EmployeeListResult>
    {
        public List<EmployeeListResult> GetAll()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Chinook"].ConnectionString))
            {
                connection.Open();

                var result = connection.Query<EmployeeListResult>("select * " +
                                                                  "from Employee");
                return result.ToList();
            }
        }
        public EmployeeListResult Get(int id)
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Chinook"].ConnectionString))
            {
                connection.Open();

                var result = connection.QueryFirstOrDefault<EmployeeListResult>(
                    "Select * From Employee where EmployeeId = @id",
                    new {id = id});

                return result;
            }
        }
    }

    public interface IRepository<T>
    {
        List<T> GetAll();
        T Get(int id);
        void Delete(int id);
        void Update(T entityToUpdate);
    }
}