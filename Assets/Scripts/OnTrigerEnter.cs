using UnityEngine;
using System.Collections;

public class OnTrigerEnter : MonoBehaviour {

    private Rigidbody2D rb;
    private Transform tr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = (Transform)GetComponent<Transform>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.tag == "enemy")
        {
            //Time.timeScale = 0;
            print("colission");
            //rb.AddForce(Vector3.up * 400);
            //transform.Translate(new Vector3(transform.position.x, transform.position.y, transform.position.z - 1));
        }
    }
}
