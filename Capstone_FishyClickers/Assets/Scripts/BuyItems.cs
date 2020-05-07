using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyItems : MonoBehaviour
{
    public PlayerData data;
    public Text info;
    public float cost;
    public int count = 0;
    public int clickPower;
    public string name;
    private float newCost;

    void Update()
    {
        info.text = name + "\nCost: " + cost + "\nPer Click: " + clickPower;
    }

    public void Purchased()
    {
        if (data.balance >= cost)
        {
            data.balance -= cost;
            count++;
            data.perClick += clickPower;
            cost = Mathf.Round(cost * 1.3f);
            newCost = cost;
            newCost = Mathf.Pow(cost, newCost);
        }
    }
}
