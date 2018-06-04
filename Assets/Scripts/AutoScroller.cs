using UnityEngine;

public class AutoScroller : MonoBehaviour
{
    private Material material;

    private bool scroll = true;

    private void Awake()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        if (scroll)
            material.mainTextureOffset = new Vector2(material.mainTextureOffset.x + Time.deltaTime * 0.1f, 0);
    }

    public void Stop()
    {
        scroll = false;
    }
}
