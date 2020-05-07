using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public PlayerData data;
    

    public void Clicked()
    {
        Debug.Log("CLICKED");
        for (int i = 0; i < data.perClick; i++)
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
}
