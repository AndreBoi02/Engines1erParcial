using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankAccount : MonoBehaviour
{
    public float balance { get; private set; }
    private EventQueue _eventQueue;

    public void Initialize(EventQueue eventQueue)
    {
        _eventQueue = eventQueue;
    }

    public void Deposit(float amount)
    {
        balance += amount;
        _eventQueue.Enqueue(new BankEvent($"Deposited {amount}. New balance: {balance}"));
    }

    public void Withdraw(float amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            _eventQueue.Enqueue(new BankEvent($"Withdrew {amount}. New balance: {balance}"));
        }
        else
        {
            _eventQueue.Enqueue(new BankEvent("Insufficient funds."));
        }
    }
}

