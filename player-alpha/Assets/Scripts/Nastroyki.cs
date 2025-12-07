using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nastroyki : MonoBehaviour
{
    public Dropdown Langulage;
    // Start is called before the first frame update
    void Start()
    {
        Langulage = GetComponent<Dropdown>();
        Langulage.ClearOptions();
        Langulage.AddOptions(new List<string> { "–”—— »…", "ENGLISH" });
        Langulage.onValueChanged.AddListener(OnOptionChanged);
    }
    void OnOptionChanged(int index)
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
