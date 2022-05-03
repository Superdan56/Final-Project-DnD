using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDrawing : MonoBehaviour {

    public GameObject deck;
    public DeckScript deckscript;
    public GameObject deckText;
    public GameObject hand;
    public GameObject cardGen;
    public Draging dragScript;
    public CardEffectScript effectScript;
    public GameObject actions;
    public ActionTracker actionNum;

    private int decksize;
    

    // Start is called before the first frame update
    void Start() {

        deck = GameObject.Find("DeckTracker");

        deckscript = deck.GetComponent<DeckScript>();

        actionNum = actions.GetComponent<ActionTracker>();

        decksize = deckscript.GetSize();

        deckText.GetComponent<TMPro.TextMeshProUGUI>().text = "Deck: " + decksize.ToString();

    }

    public void DrawHand() {
        for (int i = 0; i < 5; i++) {
            DrawCard();
        }
    }

    public void ClicktoDraw() {
        if(actionNum.GetActions() > 0) {
            DrawCard();
        }
    }

    public void DrawCard() {
        decksize -= 1;
        deckText.GetComponent<TMPro.TextMeshProUGUI>().text = "Deck: " + decksize.ToString();

        cardGen = GameObject.Find(deckscript.GenerateRandomCard());
        GameObject card = Instantiate(cardGen, new Vector2(0,0), Quaternion.identity);
        dragScript = card.GetComponent<Draging>();
        effectScript = card.GetComponent<CardEffectScript>();
        dragScript.RecallStart();
        effectScript.ReloadStart();
        card.transform.SetParent(hand.transform, false);

    }
}
