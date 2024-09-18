using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BufferTest : MonoBehaviour
{
    private DoubleBuffer<int> _doubleBuffer;

    void Start()
    {
        _doubleBuffer = new DoubleBuffer<int>();

        // Simulando la actualización de datos en el buffer
        for (int i = 0; i < 10; i++)
        {
            List<int> newData = new List<int> { i, i + 10, i + 20 };
            _doubleBuffer.UpdateBuffer(newData);
            _doubleBuffer.SwapBuffers();

            // Mostrar datos del buffer activo
            List<int> activeBuffer = _doubleBuffer.GetActiveBuffer();
            Debug.Log("Active Buffer: " + string.Join(", ", activeBuffer));
        }
    }
}
