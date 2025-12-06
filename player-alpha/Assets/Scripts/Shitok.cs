using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class Shitok : MonoBehaviour
{
    public GameObject Shelt;
    public GameObject NormSwitch;
    public GameObject BadSwitch;
    private Switch s1;
    private Switch s2;
    public int powers;
    private bool poon =false;
    // Start is called before the first frame update
    void Start()
    {
        
        int n = Random.Range(1, 4);
        if (n == 1)
        {
           
            GameObject g1 = Instantiate(BadSwitch, transform);
            
            GameObject g2 = Instantiate(NormSwitch,transform);
            s1 =  g2.GetComponent<Switch>();
            GameObject g3 =  Instantiate(NormSwitch, transform);
            s2 = g3.GetComponent<Switch>();
        }else if (n == 2)
        {
            GameObject g1 =  Instantiate(NormSwitch, transform);
            s1 = g1.GetComponent<Switch>();
            GameObject g2 = Instantiate(BadSwitch, transform);

            GameObject g3 = Instantiate(NormSwitch, transform); 
            s2 = g3.GetComponent<Switch>();
        }
        else if (n == 3)
        {
            GameObject g1 =  Instantiate(NormSwitch, transform);
            GameObject g2 =  Instantiate(NormSwitch, transform);
            s1 = g2.GetComponent<Switch>();
            GameObject g3 = Instantiate(BadSwitch, transform);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
       if (powers == 2 && !poon)
        {
            poon = true;
            Debug.Log("poon");
            //все включено
        }
    }
}
