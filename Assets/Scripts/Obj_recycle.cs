using UnityEngine;
using System.Collections;

public class Obj_recycle : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnBecameInvisible()
    {
        Recycle.instance.recycle(gameObject);
    }
}
