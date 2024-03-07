using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * This script is meant to hold the current cards in the player's deck
 * 
 * This script should be attached to the Deck gameobject
 */
public class Deck : MonoBehaviour
{
    public List<GameObject> cardsInDeck = new List<GameObject>();
    public List<GameObject> cardsInDiscardPile = new List<GameObject>();
}
