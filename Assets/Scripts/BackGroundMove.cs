using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public float moveSpeed;
    public float moveRange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        global::System.Object Nen = transform.position(new Vecto3(-1 * deltaTime, transform.position.y, 0));
    }
}
