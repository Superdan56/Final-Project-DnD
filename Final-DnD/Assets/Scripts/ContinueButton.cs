using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueButton : MonoBehaviour {

    private int TextCounter;

    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject backGround;
    public GameObject nextPart;

    void Start() {
        TextCounter = 0;

        Text1.SetActive(true);
        Text2.SetActive(false);
        Text3.SetActive(false);
        nextPart.SetActive(false);
    }

    void Update() {
        
        if (TextCounter == 1 ) {
            Text1.SetActive(false);
            Text2.SetActive(true);
        }
        else if (TextCounter == 2) {
            Text2.SetActive(false);
            Text3.SetActive(true);
        }
        
        else if (TextCounter == 3) {
            Text3.SetActive(false);
            backGround.SetActive(false);
            nextPart.SetActive(true);
            gameObject.SetActive(false);

        }

    }

    public void Continue() {
        TextCounter += 1;
    }
}
