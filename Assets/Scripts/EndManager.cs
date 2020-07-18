using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    public Text displayText;
    public GameObject theEgg;

    private bool isGameActive;
    private bool isReachDest;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        isReachDest = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameActive == true)
        {
            if (isReachDest == true)
            {
                WinGame();
            }
            else if (theEgg.transform.position.y < 1)
            {
                LoseGame();
            }
        }
    }

    void WinGame()
    {
        displayText.text = "You win!";
        EndGame();
    }

    void LoseGame()
    {
        displayText.text = "You lose!";
        EndGame();
    }

    void EndGame()
    {
        isGameActive = false;
        PlayerController playerController = FindObjectOfType<PlayerController>();
        playerController.StopAnim();
    }

    public bool CheckGameActive()
    {
        return isGameActive;
    }

    public void SetReachDest()
    {
        isReachDest = true;
    }
}
