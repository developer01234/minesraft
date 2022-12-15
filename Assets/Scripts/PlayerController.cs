using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed = 6f;

    private void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }
    }
}