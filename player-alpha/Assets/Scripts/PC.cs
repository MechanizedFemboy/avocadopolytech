using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PC : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject screen;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    public bool ClicktedHZ(Vector2 ClickPos) {  
        if (ClickPos == rb.position) {
            Debug.Log("ddfdfdf");
            return true;
            
            }
        Debug.Log("nenene");
        return false; }
    /*public GameObject Open()
    {
        return screen;
    }*/

}
