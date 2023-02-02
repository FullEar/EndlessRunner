using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsScript : MonoBehaviour
{
    public HealthScript healthS;
    public Image[] Heart;

    public void Update()
    {
        if(healthS.health < Heart.Length)
        {
            for(int i = 0; i < Heart.Length; i++)
            {
                Heart[i].enabled = false;
            }
            for (int i = 0; i < healthS.health; i++)
            {
                Heart[i].enabled = true;
            }
        }
    }
}
