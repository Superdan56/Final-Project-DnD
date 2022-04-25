using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayCard : MonoBehaviour {

    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;

    public Text health;
    public Text enemy;
    public Text actions;

    private int numActions;

    // Start is called before the first frame update
    void Start() {
        numActions = 3;
    }

    public void playcards() {
        numActions -= 1;
        actions.text = "actions: " + numActions;
    }

}
