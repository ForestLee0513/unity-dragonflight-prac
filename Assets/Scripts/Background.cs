using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float scrollSpeed = 0.3f;
    [SerializeField]
    private Material backgroundMaterial;


    void Start()
    {
        backgroundMaterial = GetComponent<Renderer>().material;
    }

    void Update()
    {
        Vector2 newOffset = backgroundMaterial.mainTextureOffset;

        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
        backgroundMaterial.mainTextureOffset = newOffset;
    }
}
