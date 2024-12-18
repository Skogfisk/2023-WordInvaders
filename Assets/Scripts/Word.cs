using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word {

    public string word;
    private int typeIndex;

    private WordDisplay display;
    public System.Action written;

    public Word (string _word, WordDisplay _display )
    {

        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter ()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        display.RemoveLetter();

    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            this.written.Invoke();
            display.RemoveWord();
        }
        return wordTyped;
    }

    void OnCollisionEnter(Collision other)
    {
    if (other.gameObject.name == "GameOverCollider")
        {
        Debug.Log("You lose");
        }
    }
  
}
