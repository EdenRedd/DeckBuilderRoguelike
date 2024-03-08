using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    public List<GameEventListener> listeners = new List<GameEventListener>();

    // Raise evenet through different methods signatures

    public void RaiseSignal(Component sender, object data)
    {
        for(int i = 0; i < listeners.Count; i++)
        {
            listeners[i].OnEventRaised(sender, data);
        }
    }

    //Manage Listeners

    public void RegisterListener(GameEventListener listener)
    {
        if( !listeners.Contains(listener) )
            listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)
    {
        if( listeners.Contains(listener) )
            listeners.Remove(listener);
    }
}
