using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meny : MonoBehaviour
{
    public GameObject Startb;
    public GameObject Setings;
    public GameObject Exit;
    public GameObject SettingsScreen;
    // Start is called before the first frame update


    // Update is called once per frame
    private void Start()
    {
        SettingsScreen.SetActive(false);
        SettingsScreen.SetActive(true);
    }
    public void StartButton()
    {
        SceneManager.LoadScene("StartingRoom");
    }
    public void SettingsButton()
    {
        SettingsScreen.SetActive(true);
    }
    public void ExitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;  // Только для редактора
#else
        Application.Quit();
#endif
    }
}
