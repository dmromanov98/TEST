using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public float yMinPosition = -300f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < yMinPosition)
            Destroy(gameObject);
    }
}
