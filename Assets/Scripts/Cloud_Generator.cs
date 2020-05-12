using UnityEngine;
using System.Collections;

public class Cloud_Generator : MonoBehaviour {

    public float rate;
    public GameObject Object;

    void Start()
    {
        StartCoroutine(CreateCloud());
    }

    IEnumerator CreateCloud()
    {
        while (true)
        {
            yield return new WaitForSeconds(rate);
            rate = Random.Range(4, 10);
            Instantiate(Object, transform.position, Quaternion.identity);
        }
    }
}
