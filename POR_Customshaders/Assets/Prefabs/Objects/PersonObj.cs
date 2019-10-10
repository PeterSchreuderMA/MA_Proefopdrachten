﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PersonObj", menuName = "PersonObj")]
public class PersonObj : ScriptableObject
{
    

    public float health;//- Life

    public float cal;//- Enegry  healthy max = 2500

    [Range(-1.5f, 8)]
    public float fat;//- Warmth  healthy max = 77g

    public float protein;// Strenth  healthy max = 56g
}
