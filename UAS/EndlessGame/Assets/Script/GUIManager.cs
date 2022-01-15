using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    public void OnPlay(){
        SceneManager.LoadScene("Menulevel");
    }

    public void OnAbout(){
        SceneManager.LoadScene("about");
    }

    public void OnHowto(){
        SceneManager.LoadScene("howtoplay");
    }

    public void OnEasy(){
        SceneManager.LoadScene("easy");
    }

    public void OnMedium(){
        SceneManager.LoadScene("main");
    }

    public void OnHard(){
        SceneManager.LoadScene("hard");
    }

    public void OnBack(){
        SceneManager.LoadScene("Menu");
    }
    

}
