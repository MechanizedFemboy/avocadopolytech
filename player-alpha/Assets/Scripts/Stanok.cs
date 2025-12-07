using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stanok : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("StartingRoom");
        }
    }

            // Update is called once per frame

}
