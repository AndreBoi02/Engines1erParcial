using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositCommand : ICommand
{
    private BankAccount _account;
    private float _amount;

    public DepositCommand(BankAccount account, float amount)
    {
        _account = account;
        _amount = amount;
    }

    public void Execute()
    {
        _account.Deposit(_amount);
    }

    public void Undo()
    {
        _account.Withdraw(_amount);
    }
}
