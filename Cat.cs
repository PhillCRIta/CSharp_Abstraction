using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Abstraction
{
    internal class Cat : Animal
    {
		public override string FunnyName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public Cat(string name) : base(name)
		{
		}

		//Speak method is mandatory to override
		internal override void Speak()
        {
            Console.Write("The cat meows");
        }
        //Sleep method can be overriden
        internal override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("The cat always sleeps");
        }
        //Eat method cannot be overriden
        //this method is only for child class Cat
        internal void CatSleepsMuch() { }
    }
}
