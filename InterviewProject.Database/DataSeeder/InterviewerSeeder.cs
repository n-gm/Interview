﻿using InterviewProject.Database.Models;
using System.Collections.Generic;

namespace InterviewProject.Database.DataSeeder
{
    public static class InterviewerSeeder
    {
        public static IEnumerable<Interviewer> SeedData()
        {
            return new Interviewer[]
            {
                new Interviewer { Id = 1, FirstName = "Иван", LastName = "Иванов", MiddleName = "Иванович" },
                new Interviewer { Id = 2, FirstName = "Петр", LastName = "Петров", MiddleName = "Петрович" },
                new Interviewer { Id = 3, FirstName = "John", LastName = "Smith", MiddleName = " " },
                new Interviewer { Id = 4, FirstName = "Hans", LastName = "Zimmer" }
            };
        }
    }
}
