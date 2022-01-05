using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fanzhuan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer renderer = this.GetComponent<SpriteRenderer>();
        renderer.flipY = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
