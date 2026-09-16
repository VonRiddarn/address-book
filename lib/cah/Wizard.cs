using System;
using System.Text;

namespace ConsoleAtHome;

class Wizard
{
	readonly StringBuilder _sb = new();

	public Wizard() { }
	public Wizard(string header) => _sb.AppendLine(header);

	public T? GetNext<T>(string label, string? prefix = null, string? suffix = null) where T : IParsable<T>
	{
		Console.Clear();
		Console.Write($"{_sb}");

		T? value = Cah.Input.ParseLine<T>(label);

		_sb.AppendLine($"{prefix}{value}{suffix}");

		return value;
	}

	public string GetNext(string label, string? prefix = null, string? suffix = null)
	{
		Console.Clear();
		Console.Write($"{_sb}\n{label}");

		string value = Console.ReadLine() ?? string.Empty;

		_sb.AppendLine($"{prefix}{value}{suffix}");

		return value;
	}

	public int GetNext(string label, string[] choices, bool showAlternatives = true, string? prefix = null, string? suffix = null)
	{
		Console.Clear();
		Console.Write($"{_sb}");

		if (showAlternatives)
			for (int i = 0; i < choices.Length; i++)
				Console.WriteLine($"* {choices[i]}");

		int value = Cah.Input.ParseCustom(label, choices);

		_sb.AppendLine($"{prefix}{value}{suffix}");

		return value;
	}
}