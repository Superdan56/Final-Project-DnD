using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour
{

    public void deleteSelf() {
        gameObject.SetActive(false);
    }

}
