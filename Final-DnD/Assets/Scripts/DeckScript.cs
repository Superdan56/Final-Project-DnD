using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckScript : MonoBehaviour {

    public List<string> decklist = new List<string>();
    public List<string> CurrentDeck = new List<string>();

    private string CurrentCard; 
    private int decksize;

    void Awake() {
        DontDestroyOnLoad(this.gameObject);
    }

    void Start() {
        decklist.Add("Strike");
        decklist.Add("Second Wind");
        decklist.Add("Action Surge");
        decklist.Add("Indominable");
        decklist.Add("Preperation");
        decklist.Add("Ambush");
        decklist.Add("Throwing Knifes");
        decklist.Add("Cunning Action");
        decklist.Add("Heal");
        decklist.Add("Harm");
        decklist.Add("Revivy");
        decklist.Add("Commune");
        decklist.Add("Eldritch Blast");
        decklist.Add("Drain Life");
        decklist.Add("Dark Bargin");
        decklist.Add("Dark Ritual");
        decklist.Add("Lightning Bolt");
        decklist.Add("Fireball");
        decklist.Add("Divintion");
        decklist.Add("Arcane Recovery");
        decksize = decklist.Count;

        CurrentDeck = decklist;

    }

    void Update() {
        decksize = decklist.Count;
    }

    public void addCard(string input) {
        print(input);
        decksize += 1;
        decklist.Add(input);
    }

    public int GetSize() {
        return decksize;
    }

    public void ResetCurrentDeck() {
        CurrentDeck = decklist;
    }

    public string GenerateRandomCard() {
        CurrentCard = CurrentDeck[Random.Range(0, CurrentDeck.Count)];
        CurrentDeck.Remove(CurrentCard);
        return CurrentCard;
    }

}
