using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text Score;
    public float InitialScore = 0f;
    public float ScoreSum = 20f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Score: " + (int)InitialScore;
        InitialScore += ScoreSum * Time.deltaTime;
    }
}
