using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Manager should:
 * - upon entering an encounter scene with a List of cardData that should be keeping track of the player's cards
 * instantiatiate them all into a gameobject under the encounterManager that is the deck so we'll always have them present in the scene
 */
public class Manager : MonoBehaviour
{
    public static Manager instance { get; private set; }

    public GameObject upArrow;

    public GameObject downArrow;

    public GameObject leftArrow;

    public GameObject rightArrow;

    static public List<CardData> overallDeck = new List<CardData>();

    public GameObject cardPrefab;

    public GameEvent onStartOfEncounter;

    private void Awake()
    {
        //Ensures that this component lives throughout scenes and destroys other gameobjects with this script attached.
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        //Starter deck but right now is just being added manually like this because we do not have a map scene
        overallDeck.Add(Resources.Load<CardData>("Cards/Card 1"));
        overallDeck.Add(Resources.Load<CardData>("Cards/Card 2"));
        overallDeck.Add(Resources.Load<CardData>("Cards/Card 3"));
        overallDeck.Add(Resources.Load<CardData>("Cards/Card 4"));
        GeneratePlayerDeckForEncounter();

        onStartOfEncounter.RaiseSignal(this, null);
    }

    /**
     * Generates all card gameobjects based on the 
     * overall deck cardData then adds them all to the
     * encounter deck.
     */
    void GeneratePlayerDeckForEncounter()
    {
        var playerDeck = GameObject.FindGameObjectWithTag("Deck").GetComponent<Deck>();
        Transform deckTransform = GameObject.FindGameObjectWithTag("Deck").transform;
        for (int i = 0; i < overallDeck.Count; i++)
        {
            var card = GameObject.Instantiate(cardPrefab);
            card.transform.parent = deckTransform;
            card.GetComponent<Card>().cardData = overallDeck[i];
            playerDeck.cardsInDeck.Add(card);
        }
    }
}
