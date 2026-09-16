using System;
using System.Collections.Generic;
using System.IO;

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
		// Make JSON from cntact dict
		// Save JSON to file.
	}

	static Dictionary<int, Contact> InitializeContacts()
	{
		// Check if contact file exists...
		// Initialize using JSON
		// Send back
		// Else empty / new

		return [];
	}
}