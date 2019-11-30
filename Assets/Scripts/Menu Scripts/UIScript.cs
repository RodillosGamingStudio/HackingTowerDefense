using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class UIScript : MonoBehaviour
{
    private GameObject canvasContainer;
    public AudioSource music;
    public AudioSource effects;
    private Canvas[] allCanvas;

    public AudioClip gameMusic;
    public AudioClip menuMusic;
    public AudioClip victory;
    public AudioClip defeat;

    public static UIScript Instance = null;

    private int currentScene;

    void Awake()
    {
        //Singleton
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);

        currentScene = 0;

        setCanvas();

        SceneManager.sceneLoaded += OnSceneLoaded;

        Clip(menuMusic);
    }

    private void resetCanvas()
    {
        foreach (Canvas canvas in allCanvas)
        {
            canvas.enabled = false;
        }
    }

    private void setCanvas()
    {
        canvasContainer = GameObject.FindGameObjectWithTag("Canvas");
        allCanvas = new Canvas[canvasContainer.transform.childCount];
        for (int i = 0; i < allCanvas.Length; i++)
        {
            allCanvas[i] = canvasContainer.transform.GetChild(i).GetComponent<Canvas>();
        }
    }

    public void ResetLevel()
    {
        ChangeSceneTo(currentScene);
    }

    public void ChangeSceneTo(int scene)
    {
        if (scene != 0) Clip(gameMusic);
        else Clip(menuMusic);
        SceneManager.LoadScene(scene);
        currentScene = scene;
    }

    public void ChangeScreenTo(int screen)
    {
        if(screen == 4)
        {
            music.Stop();
            Play(defeat);
        }
        else if(screen == 5)
        {
            music.Stop();
            Play(victory);
        }

        resetCanvas();
        allCanvas[screen].enabled = true;
    }

    public void ChangeVolume(float volume)
    {
        AudioListener.volume = volume;
    }

    public void ChangeMusicVolume(float volume)
    {
        music.volume = volume;
    }

    public void ChangeEffectsVolume(float volume)
    {
        effects.volume = volume;
    }

    public void Play(AudioClip clip)
    {
        effects.PlayOneShot(clip);
    }

    public void Clip(AudioClip clip)
    {
        music.Stop();
        Debug.Log(clip);
        music.clip = clip;
        music.Play();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (currentScene == 0)
        {
            ChangeScreenTo(0);
            Clip(menuMusic);
        }
        else
        {
            resetCanvas();
            Clip(gameMusic);
        }
    }
}
