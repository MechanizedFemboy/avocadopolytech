using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interpreter : MonoBehaviour
{
    List<string> response = new List<string>();
    public TerminalManager terminalManager;

    
    public List<string> Intepret(string userInput)
    {
        Debug.Log("Ponal0");
        response.Clear();

        string[] args = userInput.Split();
        switch (args[0])
        {
            case ("?"):
                response.Add("Ахвхвхвх хелп2x");

                return response;
                break;
            case ("выкл"):

                response.Add("Аппарат отключен.");
                terminalManager.Act("powerOff");
                return response;
                break;

            case ("вкл"):

                response.Add("Аппарат включен.");
                terminalManager.Act("powerON");
                Debug.Log("PON");
                return response;
                break;
            default:
                Debug.Log("NEPON");
                response.Add("Че?");
                return response;
                break;
        }


    }
}
