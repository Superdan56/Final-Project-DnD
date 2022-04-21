using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestChoice : MonoBehaviour {
    

    public GameObject RogueButton;
    public GameObject FighterButton;

    public GameObject RogueText;
    public GameObject FighterText;
    public GameObject Background;
    public GameObject ContinueRogue;
    public GameObject ContinueFighter;

    void Start() {
        RogueText.SetActive(false);
        FighterText.SetActive(false);
        Background.SetActive(false);
        ContinueRogue.SetActive(false);
        ContinueFighter.SetActive(false);
    }

    void Update() {
        
    }

    public void RoguePicked() {
        RogueButton.SetActive(false);
        FighterButton.SetActive(false);
        Background.SetActive(true);
        RogueText.SetActive(true);
        ContinueRogue.SetActive(true);
    }

    public void FighterPicked() {
        RogueButton.SetActive(false);
        FighterButton.SetActive(false);
        Background.SetActive(true);
        FighterText.SetActive(true);
        ContinueFighter.SetActive(true);
    }

}
