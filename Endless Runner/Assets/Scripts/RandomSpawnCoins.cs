using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnCoins : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
