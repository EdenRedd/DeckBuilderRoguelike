using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Card will be the entity of a card this will hold the animator
 * hold the data for the card and will act like an instance of a card
 * because it will be a gameobject
 * 
 * This should be attached to the gameobject prefab
 */
public class Card : MonoBehaviour
{
    [SerializeField]
    public CardData cardData;


    private void Start()
    {
        GeneratePatternGameObjects();
    }


    public void CardIsSelected(Component sender, object data)
    {
        if(data is GameObject && data == this.gameObject)
        {
            //Makes the gameObject follow the mouse.
            Vector3 mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            this.gameObject.transform.position = mousePos;
        }
    }
    void Update()
    {
        

        //if (isFollowingMouse)
        //{
        
        //}
    }

    public void GeneratePatternGameObjects()
    {
        for(int i = 0; i < cardData.pattern.Count; i++) {
            if (cardData.pattern[i] == KeyCode.UpArrow)
            {
                var upArrow = GameObject.Instantiate(Manager.instance.upArrow, this.transform.position, Manager.instance.upArrow.transform.rotation);
                upArrow.transform.parent = this.transform.GetChild(0).transform;
            }
            else if (cardData.pattern[i] == KeyCode.DownArrow)
            {
                var downArrow = GameObject.Instantiate(Manager.instance.downArrow, this.transform.position, Manager.instance.downArrow.transform.rotation);
                downArrow.transform.parent = this.transform.GetChild(0).transform;
            }
            else if (cardData.pattern[i] == KeyCode.LeftArrow)
            {
                var leftArrow = GameObject.Instantiate(Manager.instance.leftArrow, this.transform.position, Manager.instance.leftArrow.transform.rotation);
                leftArrow.transform.parent = this.transform.GetChild(0).transform;
            }
            else if (cardData.pattern[i] == KeyCode.RightArrow)
            {
                var rightArrow = GameObject.Instantiate(Manager.instance.rightArrow, this.transform.position, Manager.instance.rightArrow.transform.rotation);
                rightArrow.transform.parent = this.transform.GetChild(0).transform;
            }
        }
    }
}
