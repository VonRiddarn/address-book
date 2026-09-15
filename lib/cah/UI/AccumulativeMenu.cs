using System;
using System.Text;

namespace ConsoleAtHome;

class AccumulativeMenu
{
	readonly StringBuilder _sb = new();

	public AccumulativeMenu() { }
	public AccumulativeMenu(string header) => _sb.Append(header);

	public void Clear() => _sb.Clear();

	public string NextLine(string? conent = "") => Next($"\n{conent}");
	public string Next(string? content)
	{
		if (!string.IsNullOrEmpty(content))
			_sb.Append(content);

		return _sb.ToString();
	}

	public void RenderNextLine(string? content = "", string? prefix = null, string? suffix = null) => RenderNext($"\n{content}", prefix, suffix);
	public void RenderNext(string? content, string? prefix = null, string? suffix = null)
	{
		Console.Clear();
		Console.Write($"{prefix}{Next(content)}{suffix}");
	}

	public void Render(string? prefix = null, string? suffix = null)
	{
		Console.Clear();
		Console.Write($"{prefix}{_sb}{suffix}");
	}
}