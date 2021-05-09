using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    public float Speed = 5f;
    public bool IsRigth;

    // Update is called once per frame
    void Update()
    {
        if(IsRigth)
            {
                transform.Translate(0f, Input.GetAxis("VerticalR") * Speed * Time.deltaTime, 0f);
            }
        else
            {
                transform.Translate(0f, Input.GetAxis("VerticalL") * Speed * Time.deltaTime, 0f);
            }
        
    }
}
