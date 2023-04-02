using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
        Debug.Log("Exiting the game...");
        Application.Quit();
    }
}