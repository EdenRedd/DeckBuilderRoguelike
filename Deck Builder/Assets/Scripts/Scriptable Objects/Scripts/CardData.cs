using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CardData : ScriptableObject
{
    public List<KeyCode> pattern = new List<KeyCode>();
    public float timeLimit;
    public int cost;
    public int effect;
}
