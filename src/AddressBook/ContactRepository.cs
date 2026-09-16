using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

static class ContactRepository
{

	// GUID
	static readonly Dictionary<string, Contact> _contacts = [];

	public static Contact? RemoveContact(string guid)
	{
		bool success = _contacts.Remove(guid, out Contact? contact);
		SaveContactsToFIle();

		return success ? contact : null;
	}

	public static void AddContact(Contact contact)
	{
		// do
		// Generate GUID
		// While(!TryAdd(GUID, contact))
	}

	public static void Clear()
	{
		_contacts.Clear();
		SaveContactsToFIle();
	}

	static void SaveContactsToFIle()
	{
		string json = JsonSerializer.Serialize<Dictionary<string, Contact>>(_contacts);
		File.WriteAllText("src/data/contacts.json", json);
	}

	static Dictionary<string, Contact> InitializeContacts()
	{
		try
		{
			return JsonSerializer.Deserialize<Dictionary<string, Contact>>(File.ReadAllText("src/data/contacts.json")) ?? [];
		}
		catch
		{
			return [];
		}
	}
}