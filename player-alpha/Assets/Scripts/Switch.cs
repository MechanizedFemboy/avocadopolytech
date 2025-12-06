using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    public GameObject Way;
    public int Mod;
    
    public Shitok shitok;
    
    // Start is called before the first frame update
    void Start()
    {

        if (Mod==-1)
        {
            Way.GetComponent<VerticalLayoutGroup>().childAlignment = TextAnchor.LowerCenter;
        }
        else
        {
            Way.GetComponent<VerticalLayoutGroup>().childAlignment = TextAnchor.UpperCenter;
        }
        
    }
    private void OnMouseDown()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
            Mod = -Mod;
         
            if (1==Mod)
            {
               /* Way.GetComponent<VerticalLayoutGroup>().childAlignment = TextAnchor.LowerCenter;*/
                
            }
            else
            {
                Way.GetComponent<VerticalLayoutGroup>().childAlignment = TextAnchor.UpperCenter;
                Way.transform.parent.GetComponent<Shitok>().powers += 1;
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
