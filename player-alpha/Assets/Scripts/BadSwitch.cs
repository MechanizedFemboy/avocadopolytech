using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadSwitch : MonoBehaviour
{


    public Shitok shitok;

    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Deth();
        }
    }
    private void Deth()
    {
        Debug.Log("blaaaa");
    }
}