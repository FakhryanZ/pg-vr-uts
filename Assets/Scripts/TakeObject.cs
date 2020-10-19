using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObject : MonoBehaviour
{
    public GameObject bola, tangan;
    bool tertangkap = false;
    Vector3 posisiBola;
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        posisiBola = bola.transform.position;
        material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!tertangkap)
            {
                bola.transform.SetParent(tangan.transform);
                bola.transform.localPosition = new Vector3(-0f, -0.2f, 1.01f);
                material.color = Color.blue;
                tertangkap = true;
            }else if (tertangkap)
            {
                bola.transform.SetParent(null);
                bola.transform.localPosition = posisiBola;
                material.color = Color.red;
                tertangkap = false;
            }
        }
    }
    
}
