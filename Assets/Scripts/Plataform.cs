using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataform : MonoBehaviour
{
    [SerializeField] float Speed = 5f;
    public bool IsRigth;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        MaxPosition();

        if(IsRigth)
                transform.Translate(0f, Input.GetAxis("VerticalR") * Speed * Time.deltaTime, 0f);
        else
                transform.Translate(0f, Input.GetAxis("VerticalL") * Speed * Time.deltaTime, 0f);
    }

    void MaxPosition()
    {
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, -4, 6);
        transform.position = pos;
    }
}
