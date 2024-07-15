namespace variableExcercise;

class Program
{
    static void Main(string[] args)
    {
        //Variable Declarations
        string dogName;
        int dogAge;
        bool isHungry;
        
        //Variable Initializations
        dogName = "Rex";
        dogAge = 12;
        isHungry = true;
        double dogWeight = 67.8; //Decimals
        decimal dogHeight = 19.4m; // ends with m
        
       
        Console.WriteLine($"My dog's name is {dogName}, He is {dogAge} years old." +
                          $"He is {dogWeight} lbs, and {dogHeight} inches tall");

        Console.WriteLine($"It is {isHungry} that he is always hungry."); //String Interportation
    }
}