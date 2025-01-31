using System;
using System.Collections.Generic;

namespace DatabaseApproch.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int Salary { get; set; }

    public string City { get; set; } = null!;
}
