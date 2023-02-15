using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private SaveSystem saveSystem;
    void Start()
    {
        saveSystem = new SaveSystem(new PlayerPrefsAdapter());
    } 

   
}
