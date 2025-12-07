using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stanok : MonoBehaviour
{
    public string sceneName;
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

}
