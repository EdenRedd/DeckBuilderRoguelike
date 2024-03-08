using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * This script holds the logic to be applied to the displayed arrows
 * 
 * This script should be attached to the arrow prefab
 */
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
