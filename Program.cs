namespace _001_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myCat = new Cat("Name of cat");
            myCat.Sleep();
            myCat.Move();
            myCat.Speak();
			//myCat.CatSleepsMuch doesn't work because is not defined in the Animal class
		}
	}
}
