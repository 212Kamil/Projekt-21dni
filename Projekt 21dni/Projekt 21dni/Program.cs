using Projekt_21dni;

var employee = new Employee("Adam", "Nowak");
employee.AddGrade("Kamil");
employee.AddGrade("3222");
employee.AddGrade(2);
employee.AddGrade(6);


var statistics = employee.GetStatistics();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Average:  { statistics.Average:N2}" );
Console.WriteLine($"Max:  {statistics.Max}");
Console.WriteLine($"Min:  {statistics.Min}");

