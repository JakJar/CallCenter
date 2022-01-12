using System;

namespace CallCenter.Employees;

public abstract class Employee
{
    protected Guid Id { get; set; }
    protected string Name { get; set; }

    public Employee(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
    }
}