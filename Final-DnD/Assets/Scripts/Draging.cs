using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Draging : MonoBehaviour {

    public GameObject Canvas;
    public GameObject DropZone;
    public PlayCard playCard;

    private bool isDragging;
    private bool isOverDropZone;

    private Vector2 startPosition;


    

    void Start() {
        Canvas = GameObject.Find("Canvas");
        DropZone = GameObject.Find("DropZone");
        playCard = GetComponent<PlayCard>();

        isDragging = false;
        isOverDropZone = false;

        startPosition = transform.position;

    }

    void Update() {
        if (isDragging) {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            transform.SetParent(Canvas.transform, true);
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "Dropzone") {
            isOverDropZone = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision) {
        isOverDropZone = false;
    }

    public void StartDrag() {
        isDragging = true;
    }

    public void EndDrag() {
        isDragging = false;
        if (isOverDropZone) {
            playCard.playcards();
        }
        else {
            transform.position = startPosition;
        }
    }
}
