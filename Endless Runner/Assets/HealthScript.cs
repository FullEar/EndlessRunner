using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{
    public int health;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            SceneManager.LoadScene("LoserScene");
        }
    }
}
