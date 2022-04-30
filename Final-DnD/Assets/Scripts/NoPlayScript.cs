using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPlayScript : MonoBehaviour {

    public IEnumerator WindowAppear() {
        transform.position = new Vector2(0,0);
        yield return new WaitForSeconds(5);
        transform.position = new Vector2(100,200);
    }

    public void WindowDisappear() {
        transform.position = new Vector2(100,200);
    }

}
