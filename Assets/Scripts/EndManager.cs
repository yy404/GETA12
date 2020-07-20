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
            float distToDest = Vector3.Distance(theEgg.transform.position, destination.transform.position);
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
        displayText.text = "Win!";

        AudioPlayer audioPlayer = FindObjectOfType<AudioPlayer>();
        audioPlayer.PlaySuccess();

        EndGame();
    }

    void LoseGame()
    {
        displayText.text = "Lose!";

        AudioPlayer audioPlayer = FindObjectOfType<AudioPlayer>();
        audioPlayer.PlayFailure();

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
