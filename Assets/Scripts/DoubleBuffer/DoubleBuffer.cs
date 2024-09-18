using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DoubleBuffer<T>
{
    private List<T> _buffer1;
    private List<T> _buffer2;
    private List<T> _activeBuffer;
    private List<T> _inactiveBuffer;

    public DoubleBuffer()
    {
        _buffer1 = new List<T>();
        _buffer2 = new List<T>();
        _activeBuffer = _buffer1;
        _inactiveBuffer = _buffer2;
    }

    public void UpdateBuffer(List<T> newData)
    {
        // Copiar los nuevos datos al buffer inactivo
        _inactiveBuffer.Clear();
        _inactiveBuffer.AddRange(newData);
    }

    public void SwapBuffers()
    {
        // Intercambiar buffers
        var temp = _activeBuffer;
        _activeBuffer = _inactiveBuffer;
        _inactiveBuffer = temp;
    }

    public List<T> GetActiveBuffer()
    {
        return _activeBuffer;
    }
}

