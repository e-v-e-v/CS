using UnityEngine;
using System.Collections;

public class Cloud_Move : MonoBehaviour {

    public float speed;

    void Start()
    {
        Destroy(gameObject, 6);
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
