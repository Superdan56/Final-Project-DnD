using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{
    private int Hp;

    public GameObject win;

    void Start() {
        Hp = 20;
        win.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Health: " + Hp;
        if (Hp <= 0) {
            win.SetActive(false);
        }
    }

    public void TakeDamage(int input) {
        Hp -= input;
    }

    public void HealDamage(int input) {
        Hp += input;
    }

}
