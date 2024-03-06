using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField]
    public CardData cardData;

    private void Start()
    {
        GeneratePatternGameObjects();
    }

    public void GeneratePatternGameObjects()
    {
        for(int i = 0; i < cardData.pattern.Count; i++) {
            if (cardData.pattern[i] == KeyCode.UpArrow)
            {
                var upArrow = GameObject.Instantiate(Manager.instance.upArrow, this.transform.position, Quaternion.identity);
                upArrow.transform.parent = this.transform.GetChild(0).transform;
            }
            else if (cardData.pattern[i] == KeyCode.DownArrow)
            {
                var downArrow = GameObject.Instantiate(Manager.instance.downArrow, this.transform.position, Quaternion.identity);
                downArrow.transform.parent = this.transform.GetChild(0).transform;
            }
            else if (cardData.pattern[i] == KeyCode.LeftArrow)
            {
                var leftArrow = GameObject.Instantiate(Manager.instance.leftArrow, this.transform.position, Quaternion.identity);
                leftArrow.transform.parent = this.transform.GetChild(0).transform;
            }
            else if (cardData.pattern[i] == KeyCode.RightArrow)
            {
                var rightArrow = GameObject.Instantiate(Manager.instance.rightArrow, this.transform.position, Quaternion.identity);
                rightArrow.transform.parent = this.transform.GetChild(0).transform;
            }
        }
    }
}
