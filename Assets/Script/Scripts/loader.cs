using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class loader : MonoBehaviour
{
    public GameObject loadScreen;
    public Slider slider;
    public int scene=2;

    void Start()
    {

    }

    public void loadLevel(int sceneIndex)
    {
        sceneIndex = scene;
        scene++;
        StartCoroutine(LoadAsynchronusly(sceneIndex));
    }
    // Start is called before the first frame update
    IEnumerator LoadAsynchronusly(int sceneIndex)
    {
        sceneIndex = scene;
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadScreen.SetActive(true);
        while (!operation.isDone)
        {
           
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            yield return null;

        }
    }
}
