using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffectScript : MonoBehaviour {
    
    public GameObject player;
    public GameObject hand;
    public GameObject enemy;

    public CardDrawing draw;
    public HealthScript health;
    public EnemyHealthScript enemyhealth;

    private string cardName;
    
    void Start() {
        cardName = gameObject.name;    
    }

    public void ReloadStart() {
        player = GameObject.Find("Health");
        enemy = GameObject.Find("Enemy Health");
        hand = GameObject.Find("Hand");

        draw = hand.GetComponent<CardDrawing>();
        health = player.GetComponent<HealthScript>();
        enemyhealth = enemy.GetComponent<EnemyHealthScript>();

    }

    public void cardEffect() {
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
        else if(cardName == "Cunning Action") {

        }
        else if(cardName == "Backstab") {

        }
        else if(cardName == "Heal") {

        }
        else if(cardName == "Harm") {

        }
        else if(cardName == "Commune") {

        }
        else if(cardName == "Eldritch Blast") {

        }
        else if(cardName == "Drain Life") {

        }
        else if(cardName == "Dark Bargin") {

        }
        else if(cardName == "Dark Ritual") {

        }
        else if(cardName == "Lightning Bolt") {

        }
        else if(cardName == "Fireball") {

        }
        else if(cardName == "Divintion") {

        }

    }

}
