using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;      //Allows us to use SceneManager
using UnityEngine;

public class Loader : MonoBehaviour {

    public GameObject gameManager;          //GameManager prefab to instantiate.
    public GameObject soundManager;         //SoundManager prefab to instantiate.


    void Awake()
    {
        Debug.Log("Awake Loader.cs called");
        //Check if a GameManager has already been assigned to static variable GameManager.instance or if it's still null
        if (GameManager.instance == null)

            //Instantiate gameManager prefab
            Instantiate(gameManager);

        //Check if a SoundManager has already been assigned to static variable GameManager.instance or if it's still null
        if (SoundManager.instance == null)

            //Instantiate SoundManager prefab
            Instantiate(soundManager);
    }

    public void BackToMenuButton()
    {
        // SceneManager.UnloadScene("Main");
        SceneManager.LoadScene("Menu");
        GameManager.instance = null;
        SoundManager.instance = null;
    }
}
