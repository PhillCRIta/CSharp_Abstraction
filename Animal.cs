using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Abstraction
{
	internal abstract class Animal
	{
		public string Name { get; set; }
		public abstract string FunnyName { get; set; }
		protected Animal(string name)
		{
			Name = name;
		}
		//Abstract method must be overrided into subclass
		internal abstract void Speak();
		//Method without abstract or virtual cannot be overridden into subclass
		internal void Move()
		{
			Console.Write("The animal moves");
		}
		//Method without abstract or virtual can be overridden into subclass
		internal virtual void Sleep()
		{
			Console.WriteLine("The animal sleeps");
		}
		internal void Eat()
		{

		}
	}
}
