using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.UI;
using UnityEngine;

public class UiJournal : MonoBehaviour
{
    GameObject self;
    public Camera cam;
    void Start()
    {
        self = GetComponent<GameObject>();
    }
    void OMouseOver()
    {
        if (Input.GetMouseButtonDown(1)){
            Destroy(self);
        }
    }
    void Update()
    {
        self.transform.position = cam.transform.position;
    }
}
