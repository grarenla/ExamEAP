using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SearchClient.Models
{
    interface EmployeeApiClient
    {
        [HttpGet("/api/employees")]
        Task<List<Employee>> GetPersonsAsync();

    }
}
