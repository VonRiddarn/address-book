using System;
using System.Text;

class Menu(MenuAction[] actions, int indexOffset = 1)
{
	readonly int _indexOffset = indexOffset;
	readonly MenuAction[] _actions = actions;
	readonly StringBuilder _sb = new();

	public string GetIndexedActions(string separator = ") ")
	{
		_sb.Clear();
		for (int i = 0; i < _actions.Length; i++)
			_sb.AppendLine($"{i + _indexOffset}{separator}{_actions[i].Label}");

		return _sb.ToString().TrimEnd();
	}

	public string? GetActionIdentifier(int index)
	{
		index -= _indexOffset;

		if (index > _actions.Length || index < 0)
			return null;

		return _actions[index].Identifier;
	}


}