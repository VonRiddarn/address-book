using System.Collections.Generic;

namespace ConsoleAtHome.Scenes;

class SceneManager
{
	readonly Stack<IScene> _sceneHistory = [];

	public void Initialize(IScene startScene)
	{
		// First initialize
		_sceneHistory.Push(startScene);
		startScene.Enter();

		while (_sceneHistory.Count > 0)
		{
			var currentScene = _sceneHistory.Peek();
			var st = currentScene.Run();

			switch (st)
			{
				case SceneTransition.Push push:
					_sceneHistory.Peek().Exit();
					_sceneHistory.Push(push.Scene);
					push.Scene.Enter();
					break;

				case SceneTransition.Replace replace:
					_sceneHistory.Pop().Exit();
					_sceneHistory.Push(replace.Scene);
					replace.Scene.Enter();
					break;

				case SceneTransition.Pop:
					_sceneHistory.Pop().Exit();
					if (_sceneHistory.Count > 0)
						_sceneHistory.Peek().Enter();
					break;
			}

		}
	}
}