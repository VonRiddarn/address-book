using System;
using ConsoleAtHome;

namespace address_book;

class Program
{
	static void Main()
	{
		SceneManager sm = new();
		sm.Initialize(Scenes.Main);

		Console.WriteLine("Programmet avslutades utan fel.");
	}
}