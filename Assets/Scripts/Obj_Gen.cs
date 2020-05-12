using UnityEngine;
using System.Collections;

public class Obj_Gen : MonoBehaviour {

    public float rate;
    public GameObject Object;

    void Start()
    {
        StartCoroutine(CreateObj());
    }

    IEnumerator CreateObj()
    {
        while(true)
        {
            yield return new WaitForSeconds(rate);
            rate = Random.Range(1, 5);
            Instantiate(Object, transform.position, Quaternion.identity);
        }
    }
}
