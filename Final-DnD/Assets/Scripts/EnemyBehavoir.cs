using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavoir : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;

    public HealthScript playerHp;
    public EnemyHealthScript enemyHp;
    
    public string[] actionList = {"attack", "heal"};
    public string randAct;

    void Start() {
        playerHp = player.GetComponent<HealthScript>();
        enemyHp = enemy.GetComponent<EnemyHealthScript>();
    }

    // Update is called once per frame
    public void EnemyAction() {
        randAct = actionList[Random.Range(0, actionList.Length)];
        if(randAct == "attack") {
            playerHp.TakeDamage(5);
        }
        else {
            enemyHp.HealDamage(3);
        }
    }
}
