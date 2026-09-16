using System;
using System.Collections.Generic;
using System.IO;

static class ContactRepository
{

	static readonly Dictionary<int, Contact>? _contacts = InitializeContacts();

	static int _currentIndex = 0;

	public static void RemoveContact(Contact contact)
	{

	}

	public static void AddContact(Contact contact)
	{
	}

	public static void Clear()
	{

	}

	static void SaveContactsToFIle()
	{

	}

	static int GetCurrentIndex()
	{
		string fp = "src/data/.INDEXER";
		string fd = "src/data";

		if (!File.Exists(fp))
		{
			Directory.CreateDirectory(fd);
			File.Create(fp);
			File.WriteAllText("0", fp);
			return 0;
		}

		string sn = File.ReadAllText(fp);

		if (int.TryParse(sn, out int index))
			return index;

		throw new Exception(".INDEXER has an unparseable value.");
	}

	static Dictionary<int, Contact> InitializeContacts()
	{
		_currentIndex = GetCurrentIndex();
		// Check if contact file exists...
		// Initialize using JSON
		// Send back

		return [];
	}
}