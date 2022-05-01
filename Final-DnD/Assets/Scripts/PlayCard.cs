using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayCard : MonoBehaviour {

    public GameObject health;
    public GameObject enemy;
    public GameObject actions;
    public GameObject discard;

    private ActionTracker actionscript;

    private int numActions;
    private int discardpile;

    // Start is called before the first frame update
    void Start() {
        actionscript = actions.GetComponent<ActionTracker>();
        numActions = actionscript.GetActions();
        discardpile = 0;
        actions.GetComponent<TMPro.TextMeshProUGUI>().text = "actions: " + numActions;
        discard.GetComponent<TMPro.TextMeshProUGUI>().text = "Discard: " + discardpile;

    }

    public void playcards() {
        actionscript.RemoveOneAction();
        numActions = actionscript.GetActions();
        actions.GetComponent<TMPro.TextMeshProUGUI>().text = "actions: " + numActions;
        discardpile += 1;
        discard.GetComponent<TMPro.TextMeshProUGUI>().text = "Discard: " + discardpile;
    }

}
