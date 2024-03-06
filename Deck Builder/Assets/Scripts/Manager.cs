using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager instance { get; private set; }

    public GameObject upArrow;

    public GameObject downArrow;

    public GameObject leftArrow;

    public GameObject rightArrow;

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
}
