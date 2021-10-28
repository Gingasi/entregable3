using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public Vector3 MyPos;

    // Start is called before the first frame update
    void Start()
    {
        MyPos = Vector3.zero;
        transform.position = MyPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localScale += 2 * Vector3.one;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation *= Quaternion.Euler(45, 0, 45);
        }
    }
     }
