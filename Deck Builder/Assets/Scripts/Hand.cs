using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Hand needs to keep track of what is in it and also keep track of the energy
 * since it will be checking the cost constantly, the Manager will keep track of the players overall energy
 * Hand will receive gameobjects from deck and will determine their positions as well as play the animations for those gameobjects
 * Hand will send events to the EncounterManager and the encountermanager will decide what to do and communicate that to the rest of the objects in the scene
 * 
 * 
 */
public class Hand : MonoBehaviour
{
    public List<GameObject> cardsInHand = new List<GameObject>();

    [SerializeField] 
    private int currentEnergy;


    public void DrawCard(Component sender, object data)
    {
        if (data is List<GameObject>)
        {
            List<GameObject> cards = (List<GameObject>)data;

            cardsInHand = cards;
        }
    }
}
