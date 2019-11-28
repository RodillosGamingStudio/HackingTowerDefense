using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public GameObject canvasContainer;
    private Canvas[] allCanvas;

    void Awake()
    {
        allCanvas = new Canvas[canvasContainer.transform.childCount];
        for(int i=0; i < allCanvas.Length; i++)
        {
            allCanvas[i] = canvasContainer.transform.GetChild(i).GetComponent<Canvas>();
        }
    }

    public void ChangeSceneTo(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ChangeScreenTo(int screen)
    {
        foreach (Canvas canvas in allCanvas)
        {
            canvas.enabled = false;
        }

        allCanvas[screen].enabled = true;
    }
}
