using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioStay : MonoBehaviour
{

    public static audioStay instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(transform.gameObject);
    }
}
