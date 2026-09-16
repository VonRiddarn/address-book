using System;
using ConsoleAtHome;

class SListContacts : IScene
{
	public void Enter() { }

	public void Exit() { }

	public SceneTransition Run()
	{

		foreach (var kvp in ContactRepository.Contacts)
		{
			Console.WriteLine($"[{kvp.Key}] {kvp.Value.Name} : {kvp.Value.Number}");
		}

		Console.WriteLine("Tryck på valfri tangent för att fortsätta...");
		Console.ReadKey();
		return new SceneTransition.Pop();
	}
}