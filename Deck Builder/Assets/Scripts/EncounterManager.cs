using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/**
 * Encounter manager should keep track of the players health and it should keep track of the enemies health
 * - should be checking after every turn if it should end the game because the enemies are dead or the player is dead
 * - should be accepting the player health most likely from the managerwhen entering a scene the manager should keep track of when the scene is an encounter
 * - should be accepting enemy quantity, health, type, etc.
 * - should be keeping track of if it is the player turn or the enemy turn
 * - should be performing operations of artifacts or of operations of enemy depending on the turn
 * - should be performing actions such as drawing the player cards, discarding the player cards and reseting the players energy
 */
public class EncounterManager : MonoBehaviour
{
    public static EncounterManager instance { get; set; }

    public GameEvent onDrawCards;
    public GameEvent onCardUse;

    public int cardDrawAmount = 3;
    public bool isPlayerTurn;

    private Deck playerDeck;


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }


    public void GenerateStartingHandAndDeck()
    {
        playerDeck = GameObject.FindGameObjectWithTag("Deck").GetComponent<Deck>();
        //Hit the deck with a shuffle
        var playerHand = new List<GameObject>();

        for (int i = 0; i < cardDrawAmount; i++)
        {
            playerHand.Add(playerDeck.cardsInDeck[i]);
        }

        onDrawCards.RaiseSignal(this, playerHand);
    }


    public void handleCardLogic(Component sender, object data)
    {
        if(data is GameObject)
        {
            var gameObject = (GameObject)data;

            //Send a signal to the input verifier
            //send signal to the player if it takes damage from the card use or gains armor
            //send signal to the enemy taking damage
            onCardUse.RaiseSignal(this, gameObject);

            Debug.Log(gameObject.GetComponent<Card>().cardData.effect);
        }
        
    }
}
