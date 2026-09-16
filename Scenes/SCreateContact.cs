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
		int friends = builder.GetNext<int>("Antal vänner: ", "Du har: ", " vänner!");


		builder.RenderValues(includeHeader: true);

		Console.ReadKey();

		Console.Clear();
		Console.WriteLine($"{name} | {age} -- {friends}");

		Console.ReadKey();
		return new SceneTransition.Pop();
	}
}