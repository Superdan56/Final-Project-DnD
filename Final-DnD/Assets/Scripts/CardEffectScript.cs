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

    string cardName;

    
    void Start() {
          
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

    public void findCardName(string Input) {
        cardName = Input;
    }

    public void cardEffect() {

        if(cardName.Contains("Strike")) {
            enemyhealth.TakeDamage(5);
        }
        else if(cardName.Contains("Second Wind")) {
            health.HealDamage(5);
        }
        else if(cardName.Contains("Action Surge")) {
            actionNum.AddActions(2);
        }
        else if(cardName.Contains("Twin Strike")) {
            enemyhealth.TakeDamage(5);
            enemyhealth.TakeDamage(5);
        }
        else if(cardName.Contains("Preperation")) {
            draw.DrawCard();
            draw.DrawCard();
        }
        else if(cardName.Contains("Ambush")) {
            enemyhealth.TakeDamage(1);
            draw.DrawCard();
        }
        else if(cardName.Contains("Throwing Knifes")) {
            enemyhealth.TakeDamage(2);
            enemyhealth.TakeDamage(2);
        }
        else if(cardName.Contains("Cunning Action")) {
            draw.DrawCard();
            draw.DrawCard();
        }
        else if(cardName.Contains("Backstab")) {
            enemyhealth.TakeDamage(10);
        }
        else if(cardName.Contains("Heal")) {
            health.HealDamage(5);
        }
        else if(cardName.Contains("Harm")) {
            enemyhealth.TakeDamage(5);
        }
        else if(cardName.Contains("Commune")) {
            draw.DrawCard();
            draw.DrawCard();
        }
        else if(cardName.Contains("Eldritch Blast")) {
            enemyhealth.TakeDamage(5);
        }
        else if(cardName.Contains("Drain Life")) {
           enemyhealth.TakeDamage(2);
           health.HealDamage(2);           
        }
        else if(cardName.Contains("Dark Bargin")) {
            draw.DrawCard();
            draw.DrawCard();
            draw.DrawCard();
            health.TakeDamage(3);
        }
        else if(cardName.Contains("Dark Ritual")) {
            actionNum.AddActions(3);
            health.TakeDamage(3);
        }
        else if(cardName.Contains("Lightning Bolt")) {
            enemyhealth.TakeDamage(5);
        }
        else if(cardName.Contains("Fireball")) {
            enemyhealth.TakeDamage(5);
        }
        else if(cardName.Contains("Divintion")) {
            draw.DrawCard();
            draw.DrawCard();
        }
        else {
            Debug.Log(cardName);
        }

    }

}
