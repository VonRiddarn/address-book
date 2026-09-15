using System;
using ConsoleAtHome.Scenes;

namespace address_book;

class Program
{
	static void Main()
	{
		SceneManager sm = new();
		sm.Initialize(Scenes.Main);

		Console.WriteLine("Hello, World!");
	}
}