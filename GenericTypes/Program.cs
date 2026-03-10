//var numbers = new SimpleList<int>();
//numbers.Add(10);
//numbers.Add(20);
//numbers.Add(30);
//numbers.Add(40);
//numbers.Add(50);
//numbers.Add(60);

//numbers.RemoveAt(2);

//var words = new SimpleList<string>();
//words.Add("aaa");
//words.Add("bbb");
//words.Add("ccc");

//Console.ReadKey();


//class SimpleList<T>
//{
//    private T[] _items = new T[4];
//    private int _size = 0;

//    public void Add(T item)
//    {
//        if (_size >= _items.Length)
//        {
//            var newItems = new T[_items.Length * 2];

//            for(int i = 0; i < _items.Length; i++)
//            {
//                newItems[i] = _items[i];
//            }
//            _items = newItems;
//        }
//        _items[_size] = item;
//        ++_size;
//    }

//    public void RemoveAt(int index)
//    {
//        if(index < 0 || index >= _size)
//        {
//            throw new IndexOutOfRangeException(
//                $"Index {index} is outside the bounds of the list");
//        }

//        --_size;

//        for (int i = index; i < _size; ++i) 
//        {
//            _items[i] = _items[i + 1];
//        }

//        _items[_size] = default;
//    }

//    public T GetAtIndex(int index)
//    {
//        if (index < 0 || index >= _size)
//        {
//            throw new IndexOutOfRangeException(
//                $"Index {index} is outside the bounds of the list");
//        }
//        return _items[index];
//    }

//}

//var numbers = new List<int> { 1, 2, 3, 8, 0, 9, 10, 11, 16};
//SimpleTuple<int, int> minAndMax = GetMinAndMax(numbers);
//Console.WriteLine("Smallest number is " + minAndMax.Item1);
//Console.WriteLine("Largest number is " + minAndMax.Item2);


//Console.ReadKey();

//SimpleTuple<int, int> GetMinAndMax(IEnumerable<int> input)
//{
//    if (!input.Any())
//    {
//        throw new InvalidOperationException($"The input collection cannot be empty");
//    }
//    int min = input.First();
//    int max = input.First();

//    foreach (var number in input)
//    {
//        if (number > max)
//        {
//            max = number;
//        }
//        if (number < min)
//        {
//            min = number;
//        }
//    }

//    return new SimpleTuple<int, int>(min, max);
//}

//public class SimpleTuple<T1, T2>
//{
//    public T1 Item1 { get; }
//    public T2 Item2 { get; }

//    public SimpleTuple(T1 item1, T2 item2)
//    {
//        Item1 = item1;
//        Item2 = item2;
//    }
//}

//var decimals  = new List<decimal> { 1.1m, 2.1m, 3.22m, 12m};
//var ints = decimals.ConvertTo<decimal, int>();


//Console.ReadKey();


//static class ListExtensions
//{
//    public static void AddToFront<T>(this List<T> list, T item)
//    {
//        list.Insert(0, item);
//    }

//    public static List<TTarget> ConvertTo<TSource, TTarget>(this List<TSource> input)
//    {
//        var result = new List<TTarget>();

//        foreach(var item in input)
//        {
//            TTarget itemAfterCasting = (TTarget) Convert.ChangeType(item, typeof(TTarget));
//            result.Add(itemAfterCasting);

//        }

//        return result;
//    }


//}



//using System.Diagnostics;

//Stopwatch stopwatch = Stopwatch.StartNew();

//var ints = CreateCollectionOfRandomLength<int>(0);

//stopwatch.Stop();
//Console.WriteLine($"Execution took {stopwatch.ElapsedMilliseconds} ms.");


//Console.ReadKey();

//IEnumerable<T> CreateCollectionOfRandomLength<T>(int maxLength) where T: new()
//{
//    var length = 100000000; //new Random().Next(maxLength + 1);

//    var result = new List<T>(length);

//    for (int i = 0; i < length; ++i)
//    {
//        result.Add(new T());
//    }

//    return result;
//}


//public class Point
//{
//    public int X {  get; }
//    public int Y { get; }

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//}


//var people = new List<Person>
//{
//    new Person {Name = "John", YearOfBirth = 1980},
//    new Person {Name = "Anna", YearOfBirth = 1815},
//    new Person {Name = "Bill", YearOfBirth = 2150},

//};

//var employees = new List<Employee>
//{
//    new Employee {Name = "John", YearOfBirth = 1980},
//    new Employee {Name = "Anna", YearOfBirth = 1815},
//    new Employee {Name = "Bill", YearOfBirth = 2150},

//};

//people.Sort();

//var validPeople = GetOnlyValid(people);
//var validEmployees = GetOnlyValid(employees);

//foreach (var employee in validEmployees)
//{
//    employee.GoToWork();
//}

//Console.ReadKey();

//void PrintInOrder<T>(T first, T second) where T : IComparable<T>
//{
//    if (first.CompareTo(second) > 0)
//    {
//        Console.WriteLine($"{second} {first}");
//    }
//    else
//    {
//        Console.WriteLine($"{first} {second}");
//    }
//}

//IEnumerable<TPerson> GetOnlyValid<TPerson>(IEnumerable<TPerson> persons) where TPerson : Person
//{
//    var result = new List<TPerson>();

//    foreach (var person in persons)
//    {
//        if (person.YearOfBirth > 1990 && 
//            person.YearOfBirth < DateTime.Now.Year)
//        {
//            result.Add(person);
//        }
//    }

//    return result;
//}

//public class Person: IComparable<Person>
//{
//    public string Name { get; init; }
//    public int YearOfBirth { get; init; }

//    public override string? ToString()
//    {
//        return base.ToString();
//    }

//    public int CompareTo(Person other)
//    {
//        if (YearOfBirth < other.YearOfBirth) 
//        {
//            return 1;
//        } else if (YearOfBirth > other.YearOfBirth)
//        {
//            return -1;
//        } else
//        {
//            return 0;
//        }
//    }
//}

//public class Employee : Person
//{
//    public void GoToWork() => Console.WriteLine("Going to work");
//}


//var countryToCurrencyMapping = new Dictionary<string, string>();

//countryToCurrencyMapping.Add("USA", "USD");
//countryToCurrencyMapping.Add("India", "INR");
//countryToCurrencyMapping.Add("Spain", "EUR");

//Console.WriteLine("Cuurency in Spain is " + countryToCurrencyMapping["Spain"]);

//countryToCurrencyMapping["Poland"] = "PLN";
//countryToCurrencyMapping["Poland"] = "EUR";

//Console.WriteLine("Cuurency in Poland is " + countryToCurrencyMapping["Poland"]);


var employees = new List<Employee>
{
    new Employee("Jake Smith", "Space Navigation", 25000),
    new Employee("Anna Blake", "Space Navigation", 29000),
    new Employee("Barbara Oak", "Xenobiology", 21500),
    new Employee("Damien Parker", "Xenobiology", 22000),
    new Employee("Hisha Patel", "Machanics", 21000),
    new Employee("Gustavo Sanchez", "Machanics", 20000),

};

var result = CalculateAverageSalaryPerDepartment(employees);

Console.ReadKey();

Dictionary<string, decimal> CalculateAverageSalaryPerDepartment(IEnumerable<Employee> employees)
{
    var employeesPerDepartments = new Dictionary<string, List<Employee>>();
    foreach (var employee in employees)
    {
        if(!employeesPerDepartments.ContainsKey(employee.Department))
        {
            employeesPerDepartments[employee.Department] = new List<Employee>();
        }
        employeesPerDepartments[employee.Department].Add(employee);
    }

    var result = new Dictionary<string, decimal>();

    foreach(var employeesPerDepartment in employeesPerDepartments)
    {
        decimal sumOfsalaries = 0;

        foreach (var employee in employeesPerDepartment.Value)
        {
            sumOfsalaries += employee.MonthlySalary;
        }

        var average = sumOfsalaries / employeesPerDepartment.Value.Count;

        result[employeesPerDepartment.Key] = average;
    }

    return result;
}

public class Employee
{
    public string Name { get; init; }
    public string Department { get; init; }
    public decimal MonthlySalary { get; init; }

    public Employee(string name, string department, decimal monthlySalary)
    {
        Name = name;
        Department = department;
        MonthlySalary = monthlySalary;
    }
}