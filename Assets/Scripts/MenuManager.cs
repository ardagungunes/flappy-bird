using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject howToPlayPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        
        SceneManager.LoadScene("SampleScene");
    }

    public void HowToPlay()
    {
        howToPlayPanel.SetActive(true);
        Debug.Log("How to play clicked!");
        
    }

    public void CloseHowToPlay()
    {
        howToPlayPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }
} 

