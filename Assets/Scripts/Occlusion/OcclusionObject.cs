using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OcclusionObject : MonoBehaviour 
{
    Renderer myRend;
    public float displayTime;

    private void OnEnable() 
    {
        myRend = gameObject.GetComponent<Renderer> ();
        displayTime = -1;
    }

    void Update () 
    {
        if (displayTime > 0) {
            displayTime -= Time.deltaTime;
            myRend.enabled = true;
        } else 
        {
            myRend.enabled = false;
        }
    }

    public void HitOcclude(float time)
    {
        displayTime = time;
        myRend.enabled = true;
    }
}