using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SavedData
{
    public int FixedUnits;
    public int GamesPlayed;
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
    public static SavedData stats = new SavedData();
    public static string SaveName()
    {
        string path = Application.persistentDataPath + "/save" + ".stat";
        return path;
    }

    public static void Save()
    {
        if (File.Exists(SaveName()))
        {
            File.Delete(SaveName());
        }
        File.WriteAllText(SaveName(), JsonUtility.ToJson(stats));
    }
    public static void Load()
    {
        if (File.Exists(SaveName()))
        {
            stats = JsonUtility.FromJson<SavedData>(SaveName());
        }
        else
        {
            stats.FixedUnits = 0;
            stats.GamesPlayed = 0;
        }
    }
}
