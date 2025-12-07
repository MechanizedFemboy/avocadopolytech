using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class Stats // поля сохранения статистики
{
    public int FixedUnits;
    public int GamesPlayed;
    public List<string> brokenlist;

}
public class Situation // поля сохранения ситуации (проверяются на каждом входе в сцену, станок, щиток и т.д.)
{
    public List<string> broken;
    public List<Vector2> cords; //координаты. индекс - номер сцены
    public List<Vector2> cordsbasic; // базовые значения координат для загрузки после смерти
    
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



public static class SaveSystem
{
    public static Stats stats = new Stats();
    public static Nastroyki nastroyki = new Nastroyki();
    public static string SaveName()
    {
        string path = Application.persistentDataPath + "/save" + ".stat";
        return path;
    }

    public static void SaveStats()
    {
        if (File.Exists(SaveName()))
        {
            File.Delete(SaveName());
        }
        File.WriteAllText(SaveName(), JsonUtility.ToJson(stats));
    }
    public static void LoadStats()
    {
        if (File.Exists(SaveName()))
        {
            stats = JsonUtility.FromJson<Stats>(SaveName());
        }
        else
        {
            stats.FixedUnits = 0;
            stats.GamesPlayed = 0;
        }
    }
}
