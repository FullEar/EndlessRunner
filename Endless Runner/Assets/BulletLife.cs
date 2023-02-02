using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLife : MonoBehaviour
{
    public float Seconds = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Seconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
