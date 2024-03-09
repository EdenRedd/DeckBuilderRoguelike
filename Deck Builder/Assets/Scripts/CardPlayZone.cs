using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPlayZone : MonoBehaviour
{
    public GameEvent onCardUse;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onCardUse.RaiseSignal(this, collision.gameObject);
    }
}
