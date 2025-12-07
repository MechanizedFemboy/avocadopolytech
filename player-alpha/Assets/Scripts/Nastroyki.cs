using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Nastroyki : MonoBehaviour
{
    public GameObject L;
    public GameObject S;
    public Dropdown Langulage;
    public Toggle Sound;
    // Start is called before the first frame update
    void Start()
    {
        
        Langulage = L.GetComponent<Dropdown>();
        Sound = S.GetComponent<Toggle>();
        SaveSystem.LoadStats();
        Langulage.value = SaveSystem.stats.Lang;
        Sound.isOn = SaveSystem.stats.Sound;
        Debug.Log("L="+ SaveSystem.stats.Lang);


    }
    public void OnOptionChanged(int index)
    {
        Debug.Log("L0");
            SaveSystem.stats.Lang = index;
            SaveSystem.SaveStats();
        Debug.Log("L1");
    }
    public void Exit()
    {
        SceneManager.LoadScene("Meny");
    }
    public void OnSoundChanged(bool f)
    {
        SaveSystem.stats.Sound = f;
        SaveSystem.SaveStats();
    }
    // Update is called once per frame
    void Update()
    {
    
    }
}
