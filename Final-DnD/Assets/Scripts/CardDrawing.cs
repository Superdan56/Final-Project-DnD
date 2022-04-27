using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDrawing : MonoBehaviour {

    public GameObject deck;
    public DeckScript deckscript;
    public GameObject deckText;
    public GameObject hand;
    public GameObject Card1;

    private int decksize;
    

    // Start is called before the first frame update
    void Start() {

        deckscript = deck.GetComponent<DeckScript>();

        decksize = deckscript.GetSize();

        deckText.GetComponent<TMPro.TextMeshProUGUI>().text = "Deck: " + decksize.ToString();

        for (int i = 0; i < 5; i++) {
            DrawCard();
        }
    }

    void DrawCard() {
        GameObject card = Instantiate(Card1, new Vector2(0,0), Quaternion.identity);
        card.transform.SetParent(hand.transform, false);

    }
}
