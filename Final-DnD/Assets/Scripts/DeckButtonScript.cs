using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckButtonScript : MonoBehaviour {

    public GameObject action;
    public ActionTracker actionNum;
    public GameObject hand;
    public CardDrawing draw;

   
    void Start() {
        actionNum = action.GetComponent<ActionTracker>();
        draw = hand.GetComponent<CardDrawing>();
    }

    public void ButtonClicked() {
        actionNum.RemoveOneAction();
        draw.ClicktoDraw();
    }

}
