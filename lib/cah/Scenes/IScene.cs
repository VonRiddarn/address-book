namespace ConsoleAtHome;

interface IScene
{
	public void Enter();
	public void Exit();

	public SceneTransition Run();
}