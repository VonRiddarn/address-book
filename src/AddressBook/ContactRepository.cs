using System.Collections.Generic;

static class ContactRepository
{

	public static List<Contact> _contacts = null;
	public static List<Contact> Contacts => _contacts ??= InitializeContacts();

	static List<Contact> InitializeContacts()
	{
		// Check if contact file exists...
		// Initialize using JSON
		// Send back

		return [];
	}
}