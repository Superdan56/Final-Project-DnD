using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTracker : MonoBehaviour {

    public int Actions;

    void Start() {
        Actions = 3;
    }
    
    public int GetActions() {
        return Actions;
    }

    public void RemoveOneAction() {
        Actions -= 1;
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "actions: " + Actions;
    }

    public void RestActions() {
        Actions = 3;
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "actions: " + Actions;
    }

}
