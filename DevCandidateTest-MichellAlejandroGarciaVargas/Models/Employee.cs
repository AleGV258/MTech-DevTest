using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevCandidateTest_MichellAlejandroGarciaVargas.Models;

public class Employee
{
    public int IdEmployee { get; set; }

    public string NameEmployee { get; set; } = null!;

    public string LastNameEmployee { get; set; } = null!;

    [RegularExpression(@"[a-zA-Z]{4}[0-9]{6}[a-zA-Z0-9]{3}", ErrorMessage = "Invalid RFC Format")]
    public string RfcEmployee { get; set; } = null!;

    public DateOnly BornDateEmployee { get; set; }

    public EmployeeStatus StatusEmployee { get; set; } = EmployeeStatus.NotSet;
}
public enum EmployeeStatus
{
    NotSet,
    Active,
    Inactive,
}
