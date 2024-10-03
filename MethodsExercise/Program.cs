namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib();

            Console.WriteLine(Add(2, 4));
            Console.WriteLine(Sub(13, 500));
            Console.WriteLine(Mult(12, 12));
            Console.WriteLine(Div(144, 12));
        }










        public static void MadLib()
        {
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello,{userName}! what is your color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string FavBand = Console.ReadLine();
            Console.WriteLine("What is your favorite Animal?");
            string FavAnimal = Console.ReadLine();
            Console.WriteLine(
                $"One day, Jamimah and {userName} was walking through the woods while wearing a {favColor} t-shirt. They saw a {FavAnimal} dancing to the {FavBand} and they asked if they could join the {FavAnimal} to dance.");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b; 
        }

        public static int Mult(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / b;
        }
    }
    
    


}    
      