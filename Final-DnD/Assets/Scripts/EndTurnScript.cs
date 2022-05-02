using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurnScript : MonoBehaviour {
    
    public GameObject hand;
    public CardDrawing draw;

    public GameObject actions;
    public ActionTracker track;

    public GameObject enemy;
    public EnemyBehavoir behavoir;

    void Start() {
        draw = hand.GetComponent<CardDrawing>();
        track = actions.GetComponent<ActionTracker>();
        behavoir = enemy.GetComponent<EnemyBehavoir>();
    }

    public void EndTurnButton() {
        behavoir.EnemyAction();
        track.RestActions();
        draw.DrawCard();
    }
}
