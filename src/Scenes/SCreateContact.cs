using System;
using ConsoleAtHome;

class SCreateContact : IScene
{
	public void Enter() { }

	public void Exit() { }

	public SceneTransition Run()
	{

		Wizard builder = new("== *: Skapa kontakt :* ==");
		string name;
		string number;

		do
		{
			name = builder.GetNext("Namn: ", "Namn: ");
			number = builder.GetNext("Telefonnumer: ", "Telefonnumer: ");

			builder.RenderValues();
		} while (!Cah.Input.ParseYesNo("Stämmer detta? (Ja / Nej)"));

		ContactRepository.AddContact(new(name, number));

		return new SceneTransition.Pop();
	}
}