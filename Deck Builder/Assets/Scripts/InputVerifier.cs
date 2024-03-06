using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputVerifier : MonoBehaviour
{
    public List<KeyCode> arrowList = new List<KeyCode>();
    public Card currentCard;
    int i = 0;

    private GameObject currentPattern;

    private void Start()
    {
        arrowList = currentCard.cardData.pattern;
        currentPattern = currentCard.transform.GetChild(0).gameObject;
    }

    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            if (e.keyCode == arrowList[i])
            {
                Debug.Log("Key Pressed:" + arrowList[i]);
                currentPattern.transform.GetChild(i).gameObject.GetComponent<ArrowBehavior>().TurnGreen();
                if(i == arrowList.Count - 1)
                {
                    currentCard.gameObject.SetActive(false);
                }
                else
                {
                    i++;
                }
            }
            else
            {
                currentPattern.transform.GetChild(i).gameObject.GetComponent<ArrowBehavior>().TurnGrey();
            }
        }
    }

}
