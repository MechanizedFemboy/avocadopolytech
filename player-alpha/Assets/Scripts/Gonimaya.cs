using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gonimaya : MonoBehaviour
{
    public GameObject Gonashaya;
    public float vertimsa;
    public StanokController stanokController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vertimsa != 0)
        {
            transform.Rotate(0, 0, vertimsa * Time.deltaTime);
            stanokController.Well();
        }
    }
}
