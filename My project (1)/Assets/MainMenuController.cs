using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void OnStartClicked()
    {
        GameManager.Instance.LoadGameAndGUI();
    }

    public void OnQuitClicked()
    {
        Application.Quit();
    }
}
