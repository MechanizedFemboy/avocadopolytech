using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Unity;

public class StanokController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool power;
    public GameObject G1;
    public GameObject G3;
    public GameObject Terminal;
    private Gon Gonatel;
    private Gonimaya Gonimaya;
    private TerminalManager terminalManager;
    public GameObject[] Panels;
    public int view = 0;
    Camera cam = Camera.main;
    // Update is called once per frame
    void Start()
    {
        terminalManager = Terminal.GetComponent<TerminalManager>();
        terminalManager.stanokController = this;
        Gonatel = G1.GetComponent<Gon>();
        Gonimaya = G3.GetComponent<Gonimaya>();
        Gonimaya.stanokController = this;
        Gonatel.stanokController = this;
        Gonatel.power = power;

        Camera.main.transform.position = new Vector3(Panels[view].transform.position.x, Panels[view].transform.position.y,-10);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (view == Panels.Length - 1)
            {
                view = 0;
                Camera.main.transform.position = new Vector3(Panels[view].transform.position.x, Panels[view].transform.position.y, -10);
            }
            else
            {
                view += 1;
                Camera.main.transform.position = new Vector3(Panels[view].transform.position.x, Panels[view].transform.position.y, -10);
            }
        }
    }
    public void PowerOff()
    {
        power = false;
        Gonatel.power = power;
    }
    public void PowerOn()
    {
        Debug.Log("power");
        power = true;
        Gonatel.power = power;
    }
    public void Well()
    {
        terminalManager.AddInterpreterLines( new List<string> { "работает исправно" });

    }
}
