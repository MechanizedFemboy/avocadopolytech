using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gon : MonoBehaviour
{
    // Start is called before the first frame update

    public bool power;
    public float vertimsa;
    public StanokController stanokController;
    // Update is called once per frame
    void Update()
    {
        if (power)
        {
            
            transform.Rotate(0, 0, vertimsa * Time.deltaTime);
        }
    }
}
