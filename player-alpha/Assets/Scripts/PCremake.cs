using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PCremake : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject Terminal;
    public Transform spawnpoint;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

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
