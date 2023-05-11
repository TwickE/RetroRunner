using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up")) {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, 14, 0);
        }
    }
}
