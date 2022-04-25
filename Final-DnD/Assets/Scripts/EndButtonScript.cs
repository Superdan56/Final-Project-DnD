using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndButtonScript : MonoBehaviour {

    public GameObject Card;
    public GameObject Deck;
    
    private string CardName;
    // Start is called before the first frame update
    void Start() {
        CardName = Card.transform.name;
    }

    // Update is called once per frame
    public void ButtonClicked() {
        
    }
}
