using System.Collections;
using System.Collections.Generic;
//using Unity.Android.Gradle;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TerminalManager : MonoBehaviour
{
    public GameObject directoryLine;
    public GameObject responsableLine;

    public InputField terminalInput;
    public GameObject userInputLine;
    public ScrollRect sr;
    public GameObject msgList;
    public GameObject Controller;
    
    Interpreter interpreter;
    public StanokController stanokController;
    private void Start()
    {

        interpreter = GetComponent<Interpreter>();
        
        interpreter.terminalManager = this;


    }
    /*    public float SS= 40 f;*/ //������ ������


    private void OnGUI()
    {
        if (terminalInput.isFocused && terminalInput.text != "" && Input.GetKeyDown(KeyCode.Return)){

            //Store whatewer us typed
            string userInput = terminalInput.text;

            //clear
            ClearInputField();

            AddDictionaryLine(userInput);

            int lines = AddInterpreterLines(interpreter.Intepret(userInput));

            ScrollToButton(lines);

            userInputLine.transform.SetAsLastSibling();

            terminalInput.ActivateInputField();
            terminalInput.Select();
        
        }
    }

    void ClearInputField()
    {
        terminalInput.text = "";
    }

    void AddDictionaryLine(string userInput)
    {
        Vector2 msgListSize = msgList.GetComponent<RectTransform>().sizeDelta;
        msgList.GetComponent<RectTransform>().sizeDelta = new Vector2(msgListSize.x, msgListSize.y+ 40);

        GameObject msg = Instantiate(directoryLine, msgList.transform);

        msg.transform.SetSiblingIndex(msgList.transform.childCount-1);

        msg.GetComponentsInChildren<Text>()[1].text = userInput;
    }

    public int AddInterpreterLines(List<string> interpretation)
    {
        for (int i = 0; i < interpretation.Count; i++)
        {
            GameObject res = Instantiate(responsableLine, msgList.transform);
            res.transform.SetAsLastSibling();

            Vector2 listSize = msgList.GetComponent<RectTransform>().sizeDelta;
            msgList.GetComponent<RectTransform>().sizeDelta = new Vector2(listSize.x, listSize.y + 40f);

            
            res.GetComponentInChildren<Text>().text = interpretation[i];
                
                }
        return interpretation.Count;
    }
    void ScrollToButton(int lines)
    {
        if (lines > 4)
        {
            sr.velocity = new Vector2(0, 459);
        }
        else
        {
            sr.verticalNormalizedPosition =0;
        }
    }
    public void Act(string act)
    {
        switch (act)
        {
            case ("powerOff"):
                stanokController.PowerOff();
                break;
            case ("powerOn"):
                stanokController.PowerOn();
                break;
        }
    }
}
