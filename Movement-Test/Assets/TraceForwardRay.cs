using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraceForwardRay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward, Color.red, 0.0f);
    }
}
