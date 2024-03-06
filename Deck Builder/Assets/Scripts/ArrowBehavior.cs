using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowBehavior : MonoBehaviour
{
    [SerializeField]
    Color greenColor;

    [SerializeField]
    Color greyColor;
    public void TurnGreen()
    {
        this.gameObject.GetComponent<Image>().color = greenColor;
        
    }

    public void TurnGrey()
    {
        this.gameObject.GetComponent<Image>().color = greyColor;
    }
}
