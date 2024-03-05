using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : ScriptableObject
{
    public List<KeyCode> pattern = new List<KeyCode>();
    public float timeLimit;
    public int cost;
    public int effect;
}
