

using System.Collections.Generic;
//using Unity.Android.Gradle;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TerminalManager : MonoBehaviour
{
    public GameObject directoryLine;
    public GameObject responsableLine;
    public GameObject PoshalkoLine;
    public InputField terminalInput;
    public GameObject userInputLine;
    public ScrollRect sr;
    public GameObject msgList;
    public GameObject Controller;
    public int PoshalkoChance;
    public string[] Poshalki;
    

/*    Interpreter interpreter = new Interpreter();*/
    public StanokController stanokController;
    private void Start()
    {
/*
        interpreter = GetComponent<Interpreter>();
        
        interpreter.terminalManager = this;*/

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

            int lines = AddInterpreterLines(Intepret(userInput));
            int ch = Random.Range(0, PoshalkoChance);
            if (ch == 1)
            {
                lines += AddPoshalkoLines();
            }
           
            
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
    public int AddPoshalkoLines()
    {
        int num = Random.Range(0, Poshalki.Length);
        List<string> interpretation = new List<string>();
        interpretation.Add(Poshalki[num]);
        for (int i = 0; i < interpretation.Count; i++)
        {
            
            GameObject res = Instantiate(PoshalkoLine, msgList.transform);
            res.transform.SetAsLastSibling();

            Vector2 listSize = msgList.GetComponent<RectTransform>().sizeDelta;
            msgList.GetComponent<RectTransform>().sizeDelta = new Vector2(listSize.x, listSize.y + 40f);


            res.GetComponentInChildren<Text>().text = interpretation[i];
        }
        
        return interpretation.Count;
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
                Debug.Log("power0");
                stanokController.PowerOn();
                break;
        }
    }
    public List<string> Intepret(string userInput)
    {
        List<string> response = new List<string>();
      
        response.Clear();

        string[] args = userInput.Split();
        switch (args[0])
        {
            case ("?"):

                
                response.Add("выкл - отключение станка");
                response.Add("вкл - включение станка");
                response.Add("док - документация к машине");
                return response;
                break;
            case ("док"):
                response.Add("Стадия производства бибки -  67А");
                response.Add("      ! в целях безопасности перед починкой отключите аппарат.");
                response.Add("  Вылет передаточной шестерни:");
                response.Add("Возможные поломки:");
                response.Add("  Св-ва Асу: //-доступ запрещен-// ");
                response.Add("Оснащен Автономной Системой Управления");
                response.Add("Токарный Станок мод. Ф-420");
                
                
                

                
                
                
                return response;
                break;
            case ("выкл"):

                response.Add("Аппарат отключен.");
                Act("powerOff");
                return response;
                break;

            case ("вкл"):

                response.Add("Аппарат включен.");
                Act("powerOn");
               
                return response;
                break;
            default:
                response.Add("? - помощь");
                response.Add("такая команда отсутствует.");
                
                return response;
                break;
        }


    }
}
