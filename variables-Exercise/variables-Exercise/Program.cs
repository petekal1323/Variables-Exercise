namespace variables_Exercise;

class Program
{
    static void Main(string[] args)
    {
        string dogName = "Ralph";
        int dogAge = 5;
        char dogSex = 'M';
        double dogWeight = 65.22;
        decimal dogHeight = 2.5m;
        
        Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old. He is a {dogSex}(male) dog. He weighs {dogWeight} pounds. He is {dogHeight} feet tall.");
    }
}