using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardEffectScript : MonoBehaviour {
    
    public GameObject player;
    public GameObject hand;
    public GameObject enemy;
    public GameObject actions;

    public CardDrawing draw;
    public HealthScript health;
    public EnemyHealthScript enemyhealth;
    public ActionTracker actionNum;

    private string cardName;
    
    void Start() {
        cardName = gameObject.name;    
    }

    public void ReloadStart() {
        player = GameObject.Find("Health");
        enemy = GameObject.Find("Enemy Health");
        hand = GameObject.Find("Hand");
        actions = GameObject.Find("Actions");

        draw = hand.GetComponent<CardDrawing>();
        health = player.GetComponent<HealthScript>();
        enemyhealth = enemy.GetComponent<EnemyHealthScript>();
        actionNum = actions.GetComponent<ActionTracker>();

    }

    public void cardEffect() {
        if(cardName == "Strike") {
            enemyhealth.TakeDamage(5);
        }
        else if(cardName == "Second Wind") {
            health.HealDamage(5);
        }
        else if(cardName == "Action Surge") {
            actionNum.AddActions(2);
        }
        else if(cardName == "Twin Strike") {
            enemyhealth.TakeDamage(5);
            enemyhealth.TakeDamage(5);
        }
        else if(cardName == "Preperation") {
            draw.DrawCard();
            draw.DrawCard();
        }
        else if(cardName == "Ambush") {
            enemyhealth.TakeDamage(1);
            draw.DrawCard();
        }
        else if(cardName == "Throwing Knifes") {
            enemyhealth.TakeDamage(2);
            enemyhealth.TakeDamage(2);
        }
        else if(cardName == "Cunning Action") {
            draw.DrawCard();
            draw.DrawCard();
        }
        else if(cardName == "Backstab") {
            enemyhealth.TakeDamage(10);
        }
        else if(cardName == "Heal") {
            health.HealDamage(5);
        }
        else if(cardName == "Harm") {
            enemyhealth.TakeDamage(5);
        }
        else if(cardName == "Commune") {
            draw.DrawCard();
            draw.DrawCard();
        }
        else if(cardName == "Eldritch Blast") {
            enemyhealth.TakeDamage(5);
        }
        else if(cardName == "Drain Life") {
           enemyhealth.TakeDamage(2);
           health.HealDamage(2);           
        }
        else if(cardName == "Dark Bargin") {
            draw.DrawCard();
            draw.DrawCard();
            draw.DrawCard();
            health.TakeDamage(3);
        }
        else if(cardName == "Dark Ritual") {
            actionNum.AddActions(3);
            health.TakeDamage(3);
        }
        else if(cardName == "Lightning Bolt") {
            enemyhealth.TakeDamage(5);
        }
        else if(cardName == "Fireball") {
            enemyhealth.TakeDamage(5);
        }
        else if(cardName == "Divintion") {
            draw.DrawCard();
            draw.DrawCard();
        }

    }

}
