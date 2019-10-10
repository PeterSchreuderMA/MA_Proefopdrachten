using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Food", menuName = "Food")]
public class Food : ScriptableObject
{
    public GameObject model;

    public string name;

    public float health;//- Life
    public float cal;//- Enegry
    public float fat;//- Warmth
    public float protein;// Strenth
    

}
