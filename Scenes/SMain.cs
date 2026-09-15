using System;
using ConsoleAtHome;
using ConsoleAtHome.Scenes;

class SMain : IScene
{
	public void Enter() { }

	public void Exit() { }

	public SceneTransition Run()
	{
		Menu menu = new(
			[new("Lägg till kontakt", "ADD"),
			new("Lista kontakter", "LIST"),
			new("Avsluta", "EXIT")], indexOffset: 1);

		while (true)
		{
			Console.Clear();
			Console.WriteLine("===== *: Adressboken _* =====");
			Console.WriteLine(menu.GetIndexedActions());

			string? Identifier = menu.GetActionIdentifier(Cah.Input.ParseLine<int>("Val: "));

			switch (Identifier)
			{
				case "ADD":
					Console.WriteLine("Add some shit here yo!");
					break;
				case "LIST":
					Console.WriteLine("List some stuff here!");
					break;
				case "EXIT":
					Console.WriteLine("See you later, Schtinky!");
					break;
				default:
					Console.WriteLine("WTF??!");
					break;

			}
			Console.ReadLine();
		}
	}

}