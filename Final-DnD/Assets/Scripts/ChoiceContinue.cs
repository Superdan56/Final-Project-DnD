using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceContinue : MonoBehaviour {
    
    public GameObject pastText;
    public GameObject futureText;

    void Start() {
        
    }

    void Update() {
        
    }

    public void OnClick() {
        pastText.SetActive(false);
        futureText.SetActive(true);
    }
}
