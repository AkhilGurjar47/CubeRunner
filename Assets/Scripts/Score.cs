using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text finalScore;
    int MyScore=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = MyScore.ToString();
        finalScore.text = "Score: "+MyScore.ToString();
    }
    public void AddScore(int score)
    {
        MyScore = MyScore+score;
    }
}
