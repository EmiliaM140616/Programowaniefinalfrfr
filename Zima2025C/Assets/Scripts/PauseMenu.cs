using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnResumeButton_Clicked()
    {
        myGameStateManagerRef.StartGame(); 
    }

    // Update is called once per frame
    public void OnExitButton_Clicked()
    {
        Application.Quit();
    }
}
