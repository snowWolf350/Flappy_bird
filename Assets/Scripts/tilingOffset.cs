using UnityEngine;

public class tilingOffset : MonoBehaviour
{
    Renderer _rend;
    float _offset =0;
    public float _scrollSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _offset =+ Time.time*_scrollSpeed;
        _rend.material.SetTextureOffset("_MainTex", new Vector2(_offset, 0));
    }
}
