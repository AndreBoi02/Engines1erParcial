using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Example", menuName = "ScriptableObjects/Create New Example", order =1)]
public class FlyweightSO : ScriptableObject
{
    public Sprite sprite;
    public new string name;
    public string description;
}
