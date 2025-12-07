using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[System.Serializable]
public class Stats // поля сохранения статистики
{
    public int FixedUnits;
    public int GamesPlayed;
    public bool Sound;
    public int Lang;

}
[System.Serializable]
public class Situation // поля сохранения ситуации (проверяются на каждом входе в сцену, станок, щиток и т.д.)
{
    public List<string> broken;
    public Vector2 cords;
}


/*
    СТАТИЧЕСКИЙ КЛАСС СИСТЕМЫ СОХРАНЕНИЯ
    В связи с близостью нашей игры к рогаликам, 
    этот класс по большей части нацелен на операции
    с игровой статистикой, которая будет появляться в лобби.
    В целом, любые операции с файлстримом можно прописывать как 
    классы в этом скрипте.
    !!не забыть!! 
    -вызов функции Save() при каждой смерти
    -обращение к полям класса при каждом изменении
    назначенной им статы
    -всё это дело абильно комментировать
*/
[System.Serializable]
public static class SaveSystem
{
    public static Stats stats = new Stats();
    public static Situation sit = new Situation();
    public static string StatsName()
    {
        string path = Path.Combine(Application.persistentDataPath, "stats.json");
        return path;
    }

    public static void SaveStats()
    {
        if (File.Exists(StatsName()))
        {
            File.Delete(StatsName());
        }
        File.WriteAllText(StatsName(), JsonUtility.ToJson(stats));
    }
    public static void LoadStats()
    {
        if (File.Exists(StatsName()))
        {
            string json = File.ReadAllText(StatsName());
            stats = JsonUtility.FromJson<Stats>(json);
            Debug.Log(JsonUtility.FromJson<Stats>(json));
            
        }
        else
        {
            stats.FixedUnits = 0;
            stats.GamesPlayed = 0;
        }
    }

    public static string Savename()
    {
        string path = Path.Combine(Application.persistentDataPath, "save.json");
        return path;
    }
    public static void SaveSituation()
    {
        string json = JsonUtility.ToJson(sit, true);
        File.WriteAllText(Savename(), JsonUtility.ToJson(sit, true));
    }
    public static void LoadSituation()
    {
        if (File.Exists(Savename()))
        {
         string json = File.ReadAllText(Savename());
         sit = JsonUtility.FromJson<Situation>(json);
         Debug.Log(JsonUtility.FromJson<Situation>(json));
        }
    }
}