using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UV : MonoBehaviour
{
    private Material material;
    private float x = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        material = spriteRenderer.material;
    }

    // Update is called once per frame
    void Update()
    {
        x = Mathf.Repeat(x, 1.0f);
        //material.SetTextureOffset("_MainTex", new Vector2(x, 0));
        material.mainTextureOffset = new Vector2(x, 0);
    }
}
