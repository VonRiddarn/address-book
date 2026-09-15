namespace ConsoleAtHome.Scenes;

interface IScene
{
	public void Enter();
	public void Exit();

	public SceneTransition Run();
}