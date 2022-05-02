using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavoir : MonoBehaviour {

    public GameObject playerHp;
    public GameObject enemyHp;
    
    public string[] actionList = {"attack", "heal"};
    public string randAct;

    void Start() {
        
    }

    // Update is called once per frame
    public void EnemyAction() {
        randAct = actionList[Random.Range(0, actionList.Length)];
        if(randAct == "attack") {

        }
        else {
            
        }
    }
}
