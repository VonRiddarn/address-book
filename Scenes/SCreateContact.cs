using System;
using ConsoleAtHome;

class SCreateContact : IScene
{
	public void Enter() { }

	public void Exit() { }

	public SceneTransition Run()
	{
		Wizard builder = new("== *: Skapa kontakt :* ==");

		string name = builder.GetNext("Namn: ", "Namn: ");

		int age = builder.GetNext<int>("Ålder: ", "Ålder: ", " år");

		Console.ReadKey();

		Console.Clear();
		Console.WriteLine($"{name} | {age}");

		Console.ReadKey();
		return new SceneTransition.Pop();
	}
}