using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestChoice : MonoBehaviour {
    

    public GameObject RogueButton;
    public GameObject FighterButton;

    public GameObject RogueText;
    public GameObject FighterText;

    void Start() {
        
    }

    void Update() {
        
    }

    public void RoguePicked() {
        RogueButton.SetActive(false);
        FighterButton.SetActive(false);
        RogueText.SetActive(true);
    }

    public void FighterPicked() {
        RogueButton.SetActive(false);
        FighterButton.SetActive(false);
        FighterText.SetActive(true);
    }

}
