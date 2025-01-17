﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Stat", menuName = "Combat/Stat")]
public class Stat : ScriptableObject
{
    [SerializeField] private StatTypes statType = StatTypes.None;
    [SerializeField] private new string name = "New Stat Name";
    [Multiline] [SerializeField] private string description = "New Stat Description";

    public StatTypes StatType { get { return statType; } }
    public string Name { get { return name; } }
    public string Description { get { return description; } }
}
