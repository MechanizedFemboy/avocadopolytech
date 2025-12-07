using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemReloadTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SaveSystem.sit.broken.Clear();
        //на этом триггере все поля ситуации будут сброшены к нулю
    }
}
