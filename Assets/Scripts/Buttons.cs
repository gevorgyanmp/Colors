using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public Sprite cldown, clup;
    public GameObject hint;
    private bool showHint = false;
    public GameObject sound_on, sound_off;


    public void Start()
    {
        
        if (gameObject.name=="Sound")
        {
            if (PlayerPrefs.GetString("Sound") == "no")
            {
                clup = sound_off.GetComponent<SpriteRenderer>().sprite;
            }
            else
            {
                clup = sound_on.GetComponent<SpriteRenderer>().sprite;
            }
        }
        GetComponent<SpriteRenderer>().sprite = clup;

    }

    public void OnMouseDown()
    {
        
        GetComponent<SpriteRenderer>().sprite = cldown;
    }

    public void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = clup;
    }

    public void OnMouseUpAsButton()
    {
        if (PlayerPrefs.GetString("Sound") != "no")
        {
           GameObject.Find("Audio_Clicker").GetComponent<AudioSource>().Play();
        }
            switch (gameObject.name)
        {
            case "Play":
                SceneManager.LoadScene("Game");
                break;
            case "Help":
                if(showHint==false)
                {
                    hint.SetActive(true);
                    showHint = true;
                }
                else if(showHint==true)
                {
                    hint.SetActive(false);
                    showHint = false;
                }
                break;
            case "Share":
                Application.OpenURL("http://fb.com");
                break;
            case "Sound":
                if (PlayerPrefs.GetString("Sound") != "no")
                {
                    PlayerPrefs.SetString("Sound", "no");
                    clup = sound_off.GetComponent<SpriteRenderer>().sprite;
                    
                }
                else 
                {
                    PlayerPrefs.SetString("Sound", "yes");
                    clup = sound_on.GetComponent<SpriteRenderer>().sprite;
                   
                }
                break;
            case "Ratings":

                break;
            case "Replay":
                SceneManager.LoadScene("Game");
                break;
            case "Menu":
                SceneManager.LoadScene("Main_Menu");
                break;
            case "Recover":

                break;
            case "Ads":

                break;

        }



    }
}
