using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PCremake : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject Terminal;
    public Transform spawnpoint;
    public GameObject screen;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    // public bool ClicktedHZ(Vector2 ClickPos) {  
    //     if (ClickPos == rb.position) {
    //         Debug.Log("ddfdfdf");
    //         return true;
            
    //         }
    //     Debug.Log("nenene");
    //     return false; }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("ДЖАРВИС ПОДЁРГАЙ МОЙ ПИНАР");
            Object.Instantiate(Terminal);
        }
        //poproboval funktsyu tvoyu zloebuchyu pochinit'
        //huynya adolzhna rabotat', no ono ne vidit mysh pryam sovsem
        //skoree vsego nado porytsa v nastroukakh proekta
    }
}
