using UnityEngine;

public class UIHandler : MonoBehaviour
{
    public void StartScene(Object scene)
    {
        Application.LoadLevel(scene.name);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
