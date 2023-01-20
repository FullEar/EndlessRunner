using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour
{
    public Vector2 scrollSpeed = Vector2.one;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;    
    }

    // Update is called once per frame
    void Update()
    {
        mat.mainTextureOffset += scrollSpeed * Time.deltaTime;
    }
}
