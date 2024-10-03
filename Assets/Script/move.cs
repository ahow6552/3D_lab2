using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    //[SerializeField]
    private float speed=30;

    void Update () {
        // 方法一
        // if (Input.GetKey(KeyCode.W)) {
        //     transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        // }
        // if (Input.GetKey(KeyCode.S))
        // {
        //     transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        // }
        // if (Input.GetKey(KeyCode.A))
        // {
        //     transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        // }
        // if (Input.GetKey(KeyCode.D))
        // {
        //     transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        // }
        
        // 方法二
        // Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        // transform.position += direction * speed * Time.deltaTime;
    }

}

