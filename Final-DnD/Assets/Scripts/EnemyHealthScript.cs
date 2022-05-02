using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour {
    private int Hp;

    public GameObject win;

    void Start() {
        Hp = 20;
        win.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = "Enemy: " + Hp;
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
