using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankEvent
{
    public string Message { get; }

    public BankEvent(string message)
    {
        Message = message;
    }
}

