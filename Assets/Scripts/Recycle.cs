using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Recycle : MonoBehaviour
{

    public static Recycle instance;
    public List<GameObject> list;
    public float offset;
    public GameObject Obsticle;
    public Transform pos;
    public Transform gen_pos;

    public int counts = 0;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        generate();
        counts = list.Count;
        StartCoroutine(start_generate());
    }

    void generate()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject obj = (GameObject)Instantiate(Obsticle, pos.position, Quaternion.identity);
            obj.name = "obj_" + i;
            obj.GetComponent<Obj_recycle>().enabled = false;
            list.Add(obj);
        }
    }

    IEnumerator start_generate()
    {
        while (true)
        {
            counts = list.Count;
            yield return new WaitForSeconds(0.8f);
            GameObject obj = list[counts - 1];//get last object
            list.RemoveAt(counts - 1);
            obj.transform.position = gen_pos.position;
            obj.GetComponent<Obj_recycle>().enabled = true;
        }
    }

    public void recycle(GameObject me)
    {
        if(me != null)
        {
            me.transform.position = new Vector2(list[counts - 1].transform.position.x + offset, me.transform.position.y);
            list.Insert(0, me);
            me.GetComponent<Obj_recycle>().enabled = false;
        }
    }
}
