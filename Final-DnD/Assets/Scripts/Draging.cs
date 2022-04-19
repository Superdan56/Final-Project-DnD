using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draging : MonoBehaviour {

    public GameObject Canvas;
    private bool isDragging;
    

    void Start() {
        Canvas = GameObject.Find("Canvas");
        isDragging = false;    
    }

    
    void Update() {
        if (isDragging) {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }
    }
}
