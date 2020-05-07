using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string scene;
    public GameObject shop;
    public GameObject play;

    public void OnClick()
    {
        if (scene == "Shop")
        {
            shop.SetActive(true);
            play.SetActive(false);
        }
        else if (scene == "Return")
        {
            shop.SetActive(false);
            play.SetActive(true);
        }
        else
        {
            Debug.Log(scene);
            SceneManager.LoadScene(scene);

        }
    }
}
