using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    [SerializeField] private Image _image;
    
    private void ChangeColor()
    {
        _image.color = Color.red;
    }

    private void OnEnable()
    {
        ObserverTest.onLog.AddListener(ChangeColor);
    }

    private void OnDisable()
    {
        ObserverTest.onLog.RemoveListener(ChangeColor);
    }
}
