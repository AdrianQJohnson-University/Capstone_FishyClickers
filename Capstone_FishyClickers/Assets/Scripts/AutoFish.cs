using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoFish : MonoBehaviour
{
    public Text perSecDisplay;
    public PlayerData data;
    public BuyAuto[] items;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Auto());
    }

    // Update is called once per frame
    void Update()
    {
        perSecDisplay.text = "Per Second: " + PerSec();
    }

    public int PerSec()
    {
        int sec = 0;
        foreach (BuyAuto item in items)
        {
            sec += item.count * item.val;
        }
        return sec;
    }

    public void AutoPerSec()
    {
        for (int i = 0; i < data.perSec; i++)
        {
            int rand = Random.Range(0, 100000);
            if (rand < 85000)
            {
                data.salmon++;
            }
            else if (rand < 99999)
            {
                data.catfish++;
            }
            else if (rand < 100000)
            {
                data.gracefish++;
            }
        }
    }

    IEnumerator Auto()
    {
        while (true)
        {
            AutoPerSec();
            yield return new WaitForSeconds(1);
        }
    }
}
