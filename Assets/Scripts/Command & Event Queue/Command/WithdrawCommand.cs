using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithdrawCommand : ICommand
{
    private BankAccount _account;
    private float _amount;

    public WithdrawCommand(BankAccount account, float amount)
    {
        _account = account;
        _amount = amount;
    }

    public void Execute()
    {
        _account.Withdraw(_amount);
    }

    public void Undo()
    {
        _account.Deposit(_amount);
    }
}
