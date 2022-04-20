using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestChoice : MonoBehaviour {
    

    public GameObject RogueButton;
    public GameObject FighterButton;

    public GameObject RogueText;
    public GameObject FighterText;
    public GameObject Background;
    public GameObject Continue;

    void Start() {
        RogueText.SetActive(false);
        FighterText.SetActive(false);
        Background.SetActive(false);
        Continue.SetActive(false);
    }

    void Update() {
        
    }

    public void RoguePicked() {
        RogueButton.SetActive(false);
        FighterButton.SetActive(false);
        Background.SetActive(true);
        RogueText.SetActive(true);
        Continue.SetActive(true);
    }

    public void FighterPicked() {
        RogueButton.SetActive(false);
        FighterButton.SetActive(false);
        Background.SetActive(true);
        FighterText.SetActive(true);
        Continue.SetActive(true);
    }

}
