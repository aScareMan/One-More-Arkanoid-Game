using UnityEngine;

public class MainMenuLogic : MonoBehaviour
{
    [SerializeField] GameObject panelMenu;
    [SerializeField] GameObject panelInfo;

    public void MenuStartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);  //Будет первой в списке билда
    }
    public void MenuInfoPage()
    {
        panelInfo.SetActive(!panelInfo.activeSelf);
        panelMenu.SetActive(!panelMenu.activeSelf);
    }
    public void MenuExitGame()
    {
        Application.Quit();
    }
}
