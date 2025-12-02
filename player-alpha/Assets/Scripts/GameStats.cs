using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.UI;
using System.Net.Security;

public class GameStats : MonoBehaviour
{
    SaveSystem SS = new SaveSystem();
    public TextMeshProUGUI txt;
    void Start()
    {
        SS.Load();
        string TextENG = "total shifts finished: " + SS.stats.GamesPlayed + "\n" + "total units fixed: " + SS.stats.FixedUnits;
        string TextRU = "всего смен отработано: " + SS.stats.GamesPlayed + "\n" + "всего единиц починено: " + SS.stats.FixedUnits;
        txt.SetText(TextENG); //в будущем в зависимости от насроек тут будет if-else проверка на подстановку русской или английской локализации
    }
}
