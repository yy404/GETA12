﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ExitGame);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ExitGame()
    {
        // Debug.Log(button.gameObject.name + " was clicked");
        SceneManager.LoadScene("Menu");
    }

}
