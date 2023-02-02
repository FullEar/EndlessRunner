using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScoreOnTriggerEnter : MonoBehaviour
{
    public int pointValue = 100;

    private void OnTriggerEnter(Collider other)
    {
        ScoreManager.Instance.score += pointValue;
    }
}
