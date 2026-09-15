using System;

namespace ConsoleAtHome;

public static partial class Cah
{
	public static class TryParse
	{
		public static bool FromYesNo(string input, out bool value)
		{
			// Cache value and test happy path first to reduce actions in best case.
			value = _truthies.Contains(input, StringComparer.OrdinalIgnoreCase);

			if (value || _falsies.Contains(input, StringComparer.OrdinalIgnoreCase))
				return true;

			return false;
		}
	}
}