using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUp : MonoBehaviour {

    public GameObject FighterPath;
    public GameObject RoguePath;
    public GameObject Stage2;

    // Start is called before the first frame update
    void Start() {
        FighterPath.SetActive(false);
        RoguePath.SetActive(false);
        Stage2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
