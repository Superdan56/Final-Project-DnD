using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Draging : MonoBehaviour {

    public GameObject Canvas;
    public GameObject DropZone;
    public PlayCard playCard;
    public GameObject actions;
    public ActionTracker actionscript;

    public GameObject NoNoWindow;
    public NoPlayScript NoNoScript;

    private bool isDragging;
    private bool isOverDropZone;

    private Vector2 startPosition;
    private int actionCount;

    void Start() {

        isDragging = false;
        isOverDropZone = false;

        startPosition = transform.position;

    }

    public void RecallStart() {
        Canvas = GameObject.Find("Canvas");

        DropZone = GameObject.Find("DropZone");
        playCard = DropZone.GetComponent<PlayCard>();
        
        actions = GameObject.Find("Actions");
        actionscript = actions.GetComponent<ActionTracker>();
        
        NoNoWindow = GameObject.Find("Can't Play");
        NoNoScript = NoNoWindow.GetComponent<NoPlayScript>();
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
            if(actionscript.GetActions() < 1) {
                NoNoScript.WindowAppear();
                transform.position = startPosition;
            }
            else {
                playCard.playcards();
                gameObject.SetActive(false);
                actionCount -= 1; 
            }
        }
        else {
            transform.position = startPosition;
        }
    }
}
