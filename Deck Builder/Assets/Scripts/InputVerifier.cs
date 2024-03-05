using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputVerifier : MonoBehaviour
{
    public List<KeyCode> arrowList = new List<KeyCode>();
    int i = 0;

    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            if (e.keyCode == arrowList[i])
            {
                Debug.Log("Key Pressed:" + arrowList[i]);
                i++;
            }
        }
    }

}
