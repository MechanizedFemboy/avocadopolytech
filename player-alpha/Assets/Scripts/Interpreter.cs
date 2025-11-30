using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interpreter : MonoBehaviour
{
    List<string> response = new List<string>();
    public TerminalManager TerminalManager;
    public List<string> Intepret(string userInput)
    {
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
                TerminalManager.Act("powerOff");
                return response;
                break;

            case ("вкл"):

                response.Add("Аппарат включен.");
                TerminalManager.Act("powerON");
                Debug.Log("PON");
                return response;
                break;
            default:
                response.Add("Че?");
                return response;
                break;
        }
       
        
    }
}
