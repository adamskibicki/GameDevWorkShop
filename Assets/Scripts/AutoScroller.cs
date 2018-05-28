using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroller : MonoBehaviour
{
    private Material material;

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        material.mainTextureOffset = new Vector2(material.mainTextureOffset.x + Time.deltaTime * 0.1f, 0);
    }
}
