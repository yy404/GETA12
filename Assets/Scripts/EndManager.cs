using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    public Text displayText;

    private bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                WinGame();
            }
            if (Input.GetMouseButtonDown(1))
            {
                LoseGame();
            }
        }
    }

    void WinGame()
    {
        displayText.text = "You win!";
        isGameActive = false;
    }

    void LoseGame()
    {
        displayText.text = "You lose!";
        isGameActive = false;
    }
}
