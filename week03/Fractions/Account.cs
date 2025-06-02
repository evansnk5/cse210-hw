
using System.Collections.Generic;
using System;
public class Account
{
    public List<int> _transactions = new List<int>();
    public void Deposit(int amount)
    {
        _transactions.Add(amount);
    }
    



 }