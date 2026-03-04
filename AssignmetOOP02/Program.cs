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