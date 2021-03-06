using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Debug.Log("<b>Event:</b> GameManagerStart");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
            NextLevel();
    }

    public void NextLevel()
    {
        LevelManager.Instance.NextLevel();
    }
}
