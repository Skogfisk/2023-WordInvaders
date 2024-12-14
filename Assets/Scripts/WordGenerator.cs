using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordListEng = { "side", "walk", "table", "unhappy", "outdoor", "line", "maker", "note", "sleep", "food", "horse", "notice",
    "growing", "state", "wrong", "right", "love", "history", "computer", "working", "apply", "force", "together", "morning", "summer", "apple", "snow",
    "instructions", "warm", "construction", "break", "super", "because", "forward", "tulip", "sunshine", "fork"
     };

    private static string[] wordListFin = { "sivu", "kaunis", "pöytä", "iloinen", "ulkomaa", "linja", "maker", "viesti", "nukkua", "ruoka", "hevonen",
    "kasvaa", "maa", "väärä", "oikea", "rakkaus", "tietokone", "historia", "työvoima", "koe", "voimakas", "yhdessä", "aamu", "suvi", "omena", "lumi",
    "ohjekirja", "lämmin", "rakennus", "hajota", "onnellisuus", "taulukko", "edessä", "lamppu", "aurinko", "haarukka", "avoin", "matkustaja"
     };
    private static string[] wordList;
    public static string language = "Eng";

    public static string GetRandomWord ()
    {
        if ( language == "Fin")
        {
            wordList = wordListFin;
        }
        if ( language == "Eng")
        {
            wordList = wordListEng;
        }
        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }

}
