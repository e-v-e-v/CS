using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    //public static ScoreManager instance;
    public static int Score = 0;
    private Text txt;

    void Awake()
    {
        //if(instance == null)
        //{
        //    instance = this;
        //}
    }

	void Start()
    {
        txt = GetComponent<Text>();
        StartCoroutine(addScore());
    }

    void Update()
    {
        txt.text = getScore().ToString();
    }

    IEnumerator addScore()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.2f);
            Score++;
        }
    }

    int getScore()
    {
        return Score;
    }
}
