using System;
using ConsoleAtHome;

class SMain : IScene
{
	SceneTransition? _deferredTransition;

	public void Enter()
	{
		_deferredTransition = null;
	}

	public void Exit() { }

	public SceneTransition Run()
	{
		Menu menu = new(
			[new("Lägg till kontakt", HandleAdd),
			new("Lista kontakter", HandleList),
			new("Avsluta", HandleExit)]);

		while (true)
		{
			Console.Clear();
			Console.WriteLine("===== *: Adressboken _* =====");
			Console.WriteLine(menu.GetIndexedActions());

			Action? action = menu.GetAction(Cah.Input.ParseLine<int>("Val: "));

			if (action != null)
				action();
			else
				Console.WriteLine("Not a valid input!");

			if (_deferredTransition != null)
				return _deferredTransition;

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}
	}

	void HandleAdd()
	{
		_deferredTransition = new SceneTransition.Push(Scenes.CreateContact);
	}

	void HandleList()
	{
		_deferredTransition = new SceneTransition.Push(Scenes.ListCOntacts);
	}

	void HandleExit()
	{
		_deferredTransition = new SceneTransition.Pop();
	}
}