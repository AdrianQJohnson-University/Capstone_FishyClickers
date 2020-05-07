using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public float balance = 0;
    public int salmon = 0;
    public int catfish = 0;
    public int gracefish = 0;
    public int perClick = 1;
    public int perSec = 0;
    public int sellAll;
    public int apprentices = 0;
    public int adepts = 0;
    public int pros = 0;
    public int experts = 0;
    public int masters = 0;

    public Text balanceDisplay;
    public Text salmonDisplay;
    public Text catfishDisplay;
    public Text gracefishDisplay;
    public Text shopBal;
    public Text shopSalmon;
    public Text shopCatfish;
    public Text shopGracefish;
    public Text shopPerClick;
    public Text shopPerSec;
    public Text apprenticeDisplay;
    public Text adeptDisplay;
    public Text proDisplay;
    public Text expertDisplay;
    public Text masterDisplay;

    void Create()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        sellAll = salmon * 1 + catfish * 3 + gracefish * 100;

        balanceDisplay.text = "Balance: $" + balance;
        salmonDisplay.text = "Salmon: " + salmon;
        catfishDisplay.text = "Catfish: " + catfish;
        gracefishDisplay.text = "Gracefish: " + gracefish;
        shopBal.text = "Balance: $" + balance;
        shopSalmon.text = "Salmon: " + salmon;
        shopCatfish.text = "Catfish: " + catfish;
        shopGracefish.text = "Gracefish: " + gracefish;
        shopPerClick.text = "Per Click: " + perClick;
        shopPerSec.text = "Per Second: " + perSec;
        apprenticeDisplay.text = "Apprentices: " + apprentices;
        adeptDisplay.text = "Adepts: " + adepts;
        proDisplay.text = "Professonals: " + pros;
        expertDisplay.text = "Experts: " + experts;
        masterDisplay.text = "Masters: " + masters;

        if (balance >= 10000000)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
