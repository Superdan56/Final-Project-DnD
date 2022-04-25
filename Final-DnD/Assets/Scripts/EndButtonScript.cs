using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndButtonScript : MonoBehaviour {

    public GameObject Card;
    public GameObject Deck;
    public DeckScript deckscript; 

    private string CardName;

    // Start is called before the first frame update
    void Start() {
        CardName = Card.transform.name;
        deckscript = Deck.GetComponent<DeckScript>();
    }

    // Update is called once per frame
    public void ButtonClicked() {
        deckscript.addCard(CardName);
    }
}
