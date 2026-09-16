using System;
using System.Text;

namespace ConsoleAtHome;

class Wizard
{
	readonly string? _header = null;
	readonly StringBuilder _sb = new();

	public Wizard() { }
	public Wizard(string header) => _header = header;

	public T? GetNext<T>(string prompt, string? label = null, string? subLabel = null) where T : IParsable<T>
	{
		RenderValues();

		T? value = Cah.Input.ParseLine<T>($"{prompt}");

		_sb.AppendLine($"{label}{value}{subLabel}");

		return value;
	}

	public string GetNext(string prompt, string? label = null, string? subLabel = null)
	{
		RenderValues();
		Console.Write($"{prompt}");

		string value = Console.ReadLine() ?? string.Empty;

		_sb.AppendLine($"{label}{value}{subLabel}");

		return value;
	}

	public int GetNext(string prompt, string[] choices, bool showAlternatives = true, string? label = null, string? subLabel = null)
	{
		RenderValues(includeHeader: true);

		if (showAlternatives)
			for (int i = 0; i < choices.Length; i++)
				Console.WriteLine($"* {choices[i]}");

		int value = Cah.Input.ParseCustom($"{prompt}", choices);

		_sb.AppendLine($"{label}{value}{subLabel}");

		return value;
	}

	public void RenderValues(bool includeHeader = true, bool clear = true)
	{
		if (clear)
			Console.Clear();

		if (includeHeader)
			Console.WriteLine(_header);

		Console.Write($"{_sb}");
	}
}