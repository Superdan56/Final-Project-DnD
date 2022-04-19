using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckScript : MonoBehaviour {

    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    public GameObject Card5;
    public GameObject hand;

    // Start is called before the first frame update
    void Start() {
        for (int i = 0; i < 5; i++) {
            DrawCard();
        }
    }

    void DrawCard() {
        GameObject card = Instantiate(Card1, new Vector2(0,0), Quaternion.identity);
        card.transform.SetParent(hand.transform, false);
    }
}
