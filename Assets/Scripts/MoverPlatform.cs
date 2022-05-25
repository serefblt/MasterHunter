using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPlatform : MonoBehaviour
{
    bool yukari;
    private void Awake()
    {
    }

    private void FixedUpdate()
    {
        if (transform.position.y >= 3.5f)
            yukari = true;
        else if (transform.position.y <= -3f)
            yukari = false;

        if (yukari)
            transform.position -= new Vector3(0, 0.05f, 0);

        else
            transform.position += new Vector3(0, 0.05f, 0);

    }
}
