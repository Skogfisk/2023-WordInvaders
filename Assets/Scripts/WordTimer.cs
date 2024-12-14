using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager;

    public float wordDelay;  
    private float nextWordTime = 0f;
    public static string difficulty = "easy";

    private void Start()
    {
         if ( difficulty == "hard")  
        {
            wordDelay = 2f;
        }
        if ( difficulty == "easy")  
        {
            wordDelay = 3f;
        }
    }


    private void Update()
    {
        if (Time.time >= nextWordTime)
        {
            wordManager.AddWord();
            nextWordTime = Time.time + wordDelay;
            wordDelay *= .99f;
        }
    }

}
