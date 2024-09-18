using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventQueue : MonoBehaviour
{
    private Queue<BankEvent> _events = new Queue<BankEvent>();

    public void Enqueue(BankEvent bankEvent)
    {
        _events.Enqueue(bankEvent);
    }

    public void ProcessEvents()
    {
        while (_events.Count > 0)
        {
            BankEvent bankEvent = _events.Dequeue();
            Debug.Log(bankEvent.Message);
        }
    }
}

