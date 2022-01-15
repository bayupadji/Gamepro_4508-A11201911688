using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoadHighscore : MonoBehaviour
{
    public Text teksHighScore;
    // Start is called before the first frame update
    void Start()
    {
        teksHighScore.text = "Highscore = " + LoadHighScore().ToString();
    }


    public static int LoadHighScore(){
        int hg=0;
        if (!PlayerPrefs.HasKey ("highscore"))PlayerPrefs.SetInt("highscore",0);
        else hg=PlayerPrefs.GetInt("highscore");
        return hg;
    }
    // Update is called once per frame
    public static void SaveHighscore(int score)
    {
        int hg=0;
        if (!PlayerPrefs.HasKey ("highscore"))PlayerPrefs.SetInt("highscore",0);
        else 
        {
            // hg-=hg;
            // PlayerPrefs.SetInt("highscore", hg);
            hg=PlayerPrefs.GetInt("highscore");
            if(score >= hg)
            {
                PlayerPrefs.SetInt("highscore", score);
            }else{
            }
        }
    }
}
