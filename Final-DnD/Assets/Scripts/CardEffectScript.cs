using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffectScript : MonoBehaviour {
    
    public GameObject player;
    public GameObject hand;
    public GameObject enemy;

    private string cardName;
    
    void Start() {
        cardName = gameObject.name;    
    }

    void ReloadStart() {
        player = GameObject.Find("Health");
        enemy = GameObject.Find("Enemy Health");
        hand = GameObject.Find("Hand");
    }

    void cardPlayed() {
        if(cardName == "Strike") {

        }
        else if(cardName == "Second Wind") {

        }
        else if(cardName == "Action Surge") {

        }
        else if(cardName == "Twin Strike") {

        }
        else if(cardName == "Preperation") {

        }
        else if(cardName == "Ambush") {

        }
        else if(cardName == "Throwing Knifes") {

        }
        else if(cardName == "") {

        }
        else if(cardName == "") {

        }
        else if(cardName == "") {

        }
        else if(cardName == "") {

        }
        else if(cardName == "") {

        }
        else if(cardName == "") {

        }
    }

}
