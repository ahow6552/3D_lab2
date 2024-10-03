using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UFOController : MonoBehaviour {

    [Header("Setting")]
    public float forceValue = 2f;
    Rigidbody2D rbody2D;

    void Start () {
        rbody2D = this.GetComponent<Rigidbody2D>();
    }

    void Update () {
        // 方法一
        Vector2 force2D = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            force2D.y += forceValue;
        }
        if (Input.GetKey(KeyCode.S))
        {
            force2D.y -= forceValue;
        }
        if (Input.GetKey(KeyCode.A))
        {
            force2D.x -= forceValue;
        }
        if (Input.GetKey(KeyCode.D))
        {
            force2D.x += forceValue;
        }
        rbody2D.AddForce(force2D);

        // 方法二
        // Vector2 force2D = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * forceValue;
        // rbody2D.AddForce(force2D);
    }

    public void OnTriggerEnter2D(Collider2D other) {
       Destroy(other.gameObject);
       GameObject.Find("GameManager").GetComponent<gameManager>().addScore(100);
    }
}
