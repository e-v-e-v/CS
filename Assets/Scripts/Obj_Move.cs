using UnityEngine;
using System.Collections;

public class Obj_Move : MonoBehaviour {

    public float speed;

    void Start()
    {
        Destroy(gameObject, 4);
    }

	void Update () {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
	}
}
