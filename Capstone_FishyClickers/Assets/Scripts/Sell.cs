using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Sell : MonoBehaviour
{
    public PlayerData data;
    public Text info;
    public string name;
    public int price;

    void Start()
    {
        
    }

    void Update()
    {
        if (name == "Sell All")
        {
            price = data.sellAll;
        }
        info.text = name + "\nPrice: " + price;
    }

    public void clicked()
    {
        if (name == "Salmon")
        {
            if (data.salmon > 0)
            {
                data.salmon--;
                data.balance += price;
            }
        }
        else if (name == "Catfish")
        {
            if (data.catfish > 0)
            {
                data.catfish--;
                data.balance += price;
            }
        }
        else if (name == "Gracefish")
        {
            if (data.gracefish > 0)
            {
                data.gracefish--;
                data.balance += price;
            }
        }
    }

    public void sellAll() {
        data.balance += data.sellAll;
        data.salmon = 0;
        data.catfish = 0;
        data.gracefish = 0;
    }
}
