using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class Stanok : MonoBehaviour
{
    public string sceneName;
    public string SceneOkay;
    public string ID;
    string destination;
    void Awake()
    {
        SaveSystem.LoadSituation();
        destination = SaveSystem.sit.broken.Contains(ID)?sceneName:SceneOkay;
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(destination);
        }

    }
    
}
