using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interpreter : MonoBehaviour
{
    List<string> response = new List<string>();

    public List<string> Intepret(string userInput)
    {
        response.Clear();

        string[] args = userInput.Split();

        if (args[0] == "help")
        {

            response.Add("Àõâõâõâõ õåëï");
            response.Add("Àõâõâõâõ õåëï2x");

            return response;

        }
        else
        {
            response.Add("×å?");
            return response;
        }
    }
}
