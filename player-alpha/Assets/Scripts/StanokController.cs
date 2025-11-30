using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    // Update is called once per frame
    void Start()
    {
        terminalManager = Terminal.GetComponent<TerminalManager>();
        terminalManager.stanokController = this;
        Gonatel = G1.GetComponent<Gon>();
        Gonimaya = G3.GetComponent<Gonimaya>();
        Gonatel.power = power;
    }
    public void PowerOff()
    {
        power = false;
        Gonatel.power = power;
    }
    public void PowerOn()
    {
        power = true;
        Gonatel.power = power;
    }
    public void Well()
    {
        terminalManager.AddInterpreterLines( new List<string> { "работает исправно" });
    }
}
