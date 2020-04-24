
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class Navigator : ScriptableObject
{
    public void NavigateToScene1() => LoadScene("Scene1");
    public void NavigateToScene2() => LoadScene("Scene2");

    private void LoadScene(string sceneName) => SceneManager.LoadScene(sceneName);
}
