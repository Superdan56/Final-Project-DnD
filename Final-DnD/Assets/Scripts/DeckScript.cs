using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeckScript : MonoBehaviour {

    public GameObject deckText;

    private List<string> decklist = new List<string>();
    private int decksize;

    void Start() {
        decklist.Add("Strike");
        decklist.Add("Second Wind");
        decklist.Add("Action Surge");
        decklist.Add("Indominable");
        decklist.Add("Preperation");
        decklist.Add("Ambush");
        decklist.Add("Throwing Knives");
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
        decklist.Add("Firebolt");
        decklist.Add("Divination");
        decklist.Add("Arcane Recovery");
        decksize = decklist.Count;
        if (deckText != null) {
            deckText.GetComponent<TMPro.TextMeshProUGUI>().text = "Deck: " + decksize.ToString();
        }
    }

    public void UpdateDeckSize() {
        deckText.GetComponent<TMPro.TextMeshProUGUI>().text = "Deck: " + decksize.ToString();
    }

    public void addCard(string input) {
        decksize += 1;
        decklist.Add(input);
    }

}
