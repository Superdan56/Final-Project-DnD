using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayCard : MonoBehaviour {

    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;

    public GameObject health;
    public GameObject enemy;
    public GameObject actions;
    public GameObject discard;

    private int numActions;
    private int discardpile;

    // Start is called before the first frame update
    void Start() {
        numActions = 3;
        discardpile = 0;
        actions.GetComponent<TMPro.TextMeshProUGUI>().text = "actions: " + numActions;
        discard.GetComponent<TMPro.TextMeshProUGUI>().text = "Discard: " + discardpile;

    }

    public void playcards() {
        numActions -= 1;
        actions.GetComponent<TMPro.TextMeshProUGUI>().text = "actions: " + numActions;
        discardpile += 1;
        discard.GetComponent<TMPro.TextMeshProUGUI>().text = "Discard: " + discardpile;
    }

}
