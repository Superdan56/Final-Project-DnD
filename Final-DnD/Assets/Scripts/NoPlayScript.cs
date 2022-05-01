using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPlayScript : MonoBehaviour {

    public void Start() {
        transform.position = new Vector2(10000,200000);
    }

    public void WindowAppear() {
        transform.position = new Vector2(150,45);
        
    }

    public void WindowDisappear() {
        transform.position = new Vector2(10000,200000);
    }

}
