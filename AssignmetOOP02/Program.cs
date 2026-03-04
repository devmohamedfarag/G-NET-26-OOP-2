#region Question01:
/*
  public class BankAccount
 {
    public string Owner;
    public double Balance;

    public void Withdraw(double amount)
    {
        Balance -= amount;
    }
}
 */

// a): Identify at least two problems with this design from an encapsulation perspective.
// Answer: 1- own and Balance fields are public, which allows external code to directly access and modify them, potentially leading to inconsistent or invalid states of the BankAccount object.
//         2- The Withdraw method does not have any validation to check if the amount being withdrawn is greater than the current balance, which could lead to negative balances and financial issues.

// b): Describe how you would fix this class to follow proper encapsulation principles. You do not need to write the full code.
// Answer: 1- Make Owner and Balance fields private to prevent direct access from outside the class.
//         2- Use Properties to provide controlled access to these fields, allowing for validation and ensuring that the internal state of the BankAccount object remains consistent.

// c) Explain why exposing fields directly (as public) is considered a bad practice in OOP.
// Answer: Public fields are bad practice because it breaks the encapsulation principle of OOP.
//         And No validation possible that we can not control values that are being assigned to the fields.

#endregion

#region Question02:
َ// Q01: What is the difference between a field and a property in C#? Can a property contain logic? Give an example of a read-only property that returns a calculated value.

// Answer: A field is a variable that is declared directly in a class or struct and can be accessed directly.
//         A property, on the other hand, is a member that provides a flexible mechanism to read, write, or compute the value of a private field.
//         Properties can contain logic in their get and set accessors, allowing for validation, transformation, or other operations when getting or setting values.
// Example of a read-only property that returns a calculated value:
/*
 public class Person
{
    private readonly string _firstName;
    private readonly string _lastName;

    public Person(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }

    public string FullName
    {
        get
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
 */
#endregion

#region Question03:
/*
 public class StudentRegister
{
    private string[] names = new string[5];

    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}
 */

//a) What is `this[int index]` called? Explain its purpose.
// Answer: `this[int index]` is called an indexer in C#.
//         It allows instances of the StudentRegister class to be indexed like an array.
//         The purpose of the indexer is to provide a way to access and modify the elements of the names array using an index, making it easier to work with collections of data without exposing the underlying array directly.

//b) What happens if someone writes `register[10] = "Ali";` ? How would you make the indexer safer?
// Answer: If someone writes `register[10] = "Ali";`, it will throw an `IndexOutOfRangeException` because the index 10 is out of bounds for the names array, which has a length of 5.

//C) Can a class have more than one indexer? If yes, give an example of when that would be useful.
// Answer: Yes, a class can have more than one indexer in C#.
//         This can be useful when you want to provide different ways to access the data in the class.
//         For example, you could have one indexer that allows access by integer index and another that allows access by string key:
/*
 public class StudentRegister
{
    private string[] names = new string[5];
    private Dictionary<string, int> nameToIndex = new Dictionary<string, int>();
    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
    public int this[string name]
    {
        get { return nameToIndex[name]; }
        set { nameToIndex[name] = value; }
    }
}
 */

#endregion

