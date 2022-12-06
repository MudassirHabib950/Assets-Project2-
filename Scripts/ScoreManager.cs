using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text highScoreText;
    public static ScoreManager Instance;
    

    public static int score=0;
    int highscore=18;
    private void Awake()
    {
        Instance=this;
    }
    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.GetInt("highscore",0);
        scoreText.text=score.ToString()+"Points";
        highScoreText.text="HIGHSCORE:" + highscore.ToString();
    }
   

   void AddPoint()
    {
     if(score%3==0)
     {
        Debug.Log("one star added");
     }

     score+= 1;
     Debug.Log(score);
     scoreText.text=score.ToString()+"Points";
     if(highscore<score)
     
     PlayerPrefs.SetInt("highscore",score);

    }
   
}
