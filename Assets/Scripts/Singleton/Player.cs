using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    private void Awake()
    {
        if (instance)
            Destroy(this.gameObject);
        else
            instance = this;
    }

    public void PrintText()
    {
        Debug.Log("WAOS IS WORKING");
    }
}
