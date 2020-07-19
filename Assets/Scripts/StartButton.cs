using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Button button;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        // Debug.Log(button.gameObject.name + " was clicked");
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

}
