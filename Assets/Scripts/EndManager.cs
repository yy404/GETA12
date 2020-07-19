using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndManager : MonoBehaviour
{
    public Text displayText;
    public GameObject theEgg;
    public GameObject destination;
    public float destRangeRadius;
    public float eggRangeRadius;

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
            float distToDest = Mathf.Abs(theEgg.transform.position.z - destination.transform.position.z);
            if (distToDest < destRangeRadius)
            {
                WinGame();
            }
            else if (theEgg.transform.position.y < eggRangeRadius)
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
        Time.timeScale = 0;
    }

    public bool CheckGameActive()
    {
        return isGameActive;
    }
}
