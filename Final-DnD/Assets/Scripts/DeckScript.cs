using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckScript : MonoBehaviour {

    public GameObject deckText;
    public string card;

    private string[] decklist;
    private int decksize;

    void Start() {
        decklist = new string[] {"Strike", "Second Wind", "Action Surge", "Indominable", "Preperation", "Ambush", "Throwing Knives", "Cunning Action", "Heal", "Harm", "Revivy", "Commune", "Eldritch Blast", "Drain Life", "Dark Bargin", "Dark Ritual", "Lightning Bolt", "Firebolt", "Divination", "Arcane Recovery" };
        decksize = decklist.Length;
        deckText.GetComponent<Text>().text = "Deck: " + decksize.ToString();  
    }

    public void UpdateDeckSize() {
        deckText.GetComponent<Text>().text = "Deck: " + decksize.ToString();
    }

    public void addCard() {

    }

}
