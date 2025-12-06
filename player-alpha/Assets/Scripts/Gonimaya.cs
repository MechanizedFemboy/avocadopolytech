using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gonimaya : MonoBehaviour
{
    public GameObject Gonashaya;
    public float vertimsa;
    public StanokController stanokController;
    bool w = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Well(float n)
    {
        if (w)
        {
            vertimsa = n;
            stanokController.Well();
            w = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (vertimsa != 0)
        {
            transform.Rotate(0, 0, vertimsa * Time.deltaTime);
            
        }
    }
}
