using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CnEQTest : MonoBehaviour
{
    public BankAccount bankAccount;
    public EventQueue eventQueue;
    public CommandInvoker commandInvoker;

    void Start()
    {
        // Inicializa el BankAccount con la EventQueue
        bankAccount.Initialize(eventQueue);

        // Crear comandos
        ICommand depositCommand = new DepositCommand(bankAccount, 100f);
        ICommand withdrawCommand = new WithdrawCommand(bankAccount, 50f);

        // Ejecutar comandos
        commandInvoker.SetCommand(depositCommand);
        commandInvoker.ExecuteCommand();
        
        commandInvoker.SetCommand(withdrawCommand);
        commandInvoker.ExecuteCommand();

        // Procesar eventos
        eventQueue.ProcessEvents();
    }
}
