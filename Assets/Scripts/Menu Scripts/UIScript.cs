using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class UIScript : MonoBehaviour
{
    public GameObject canvasContainer;
    public GameObject music;
    public GameObject effects;
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

    public void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void ChangeMusicVolume(float volume)
    {
        AudioSource audio = music.GetComponent<AudioSource>();
        audio.volume = volume;
    }

    public void ChangeEffectsVolume(float volume)
    {
        AudioSource audio = effects.GetComponent<AudioSource>();
        audio.volume = volume;
    }

    public void play(AudioClip clip)
    {
        AudioSource audio = effects.GetComponent<AudioSource>();
        audio.PlayOneShot(clip);
    }
}
