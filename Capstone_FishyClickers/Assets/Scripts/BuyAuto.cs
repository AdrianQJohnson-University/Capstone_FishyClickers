using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyAuto : MonoBehaviour
{
    public Text info;
    public PlayerData data;
    public float cost;
    public int val;
    public int count;
    public string name;
    private float baseCost;

    // Start is called before the first frame update
    void Start()
    {
        baseCost = cost;
    }

    // Update is called once per frame
    void Update()
    {
        info.text = name + "\nCost: " + cost + "\nPer Second: " + val;
    }

    public void Purchased()
    {
        if (data.balance >= cost)
        {
            data.balance -= cost;
            data.perSec += val;
            count += 1;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));

            if (name == "Hire Apprentice")
            {
                data.apprentices++;
            }
            else if (name == "Hire Adept")
            {
                data.adepts++;
            }
            else if (name == "Hire Professional")
            {
                data.pros++;
            }
            else if (name == "Hire Expert")
            {
                data.experts++;
            }
            else if (name == "Hire Master")
            {
                data.masters++;
            }
        }
    }
}
