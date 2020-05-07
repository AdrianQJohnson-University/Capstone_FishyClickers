using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePrefs : MonoBehaviour
{
    private int balance;
    private int salmon;
    private int catfish;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("balance", balance);
        PlayerPrefs.SetInt("salmon", salmon);
        PlayerPrefs.SetInt("catfish", catfish);
    }

    void Awake()
    {
        if (PlayerPrefs.HasKey("balance") || PlayerPrefs.HasKey("salmon") || PlayerPrefs.HasKey("catfish"))
        {
            balance = PlayerPrefs.GetInt("balance");
            salmon = PlayerPrefs.GetInt("salmon");
            catfish = PlayerPrefs.GetInt("catfish");
        }
    }
}
