using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using UnityEngine.UI;

public class GameStats : MonoBehaviour
{
    public TextMeshProUGUI txt;
    void Start()
    {
        SaveSystem.LoadStats();
        string TextENG = "total shifts finished: " + SaveSystem.stats.GamesPlayed + "\n" + "total units fixed: " + SaveSystem.stats.FixedUnits;
        string TextRU = "всего смен отработано: " + SaveSystem.stats.GamesPlayed + "\n" + "всего единиц починено: " + SaveSystem.stats.FixedUnits;
        txt.text = TextRU; //в будущем в зависимости от насроек тут будет if-else проверка на подстановку русской или английской локализации
    }
}
