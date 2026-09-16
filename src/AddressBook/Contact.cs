using System.Text;

class Contact(string Name, string Number)
{
	public string Name { get; private set; } = Name;
	public string Number { get; private set; } = Number;

	public void ChangeName(string newName) => Name = newName;
	public void ChangeNumber(string newNumber) => Number = newNumber;


}