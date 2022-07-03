using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubRotate : MonoBehaviour
{
    float RotationDirection = 0;
    Transform PondTran;
    Transform PlayerTran;
    Vector3 RotationAxis;
    // Start is called before the first frame update
    void Start()
    {
        PondTran = GetComponent<Transform>();
        RotationAxis.x = 0;
        RotationAxis.y = 1;
        RotationAxis.z = 0;
        PlayerTran = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            PlayerTran.rotation = Quaternion.Euler(-90,180,-90);
            RotationDirection = 1;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            PlayerTran.rotation = Quaternion.Euler(-90, 0, -90);
            RotationDirection = -1;
        }
        else
        {
            RotationDirection = 0;
        }

        PondTran.Rotate(RotationAxis, RotationDirection);        
    }
}
