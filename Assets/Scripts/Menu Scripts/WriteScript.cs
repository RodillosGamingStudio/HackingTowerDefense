using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WriteScript : MonoBehaviour
{
    private string textAux;
    private float timer;
    private Text text;
    private int current;
    private Canvas parentCanvas;

    void Awake()
    {
        parentCanvas = transform.GetComponentInParent<Canvas>();
        text = gameObject.GetComponent<Text>();
        textAux = text.text;
        OnParentDisabled();
    }

    private void OnParentDisabled()
    {
        current = 0;
        timer = 0.1f;
        text.text = "";
    }

    void Update()
    {
        if (parentCanvas.enabled)
        {
            timer -= Time.deltaTime;
            if (Input.anyKeyDown)
            {
                text.text = textAux;
                current = textAux.Length;
            }
            else if (timer <= 0 && current <= textAux.Length)
            {
                text.text = textAux.Substring(0, current);
                current++;
                timer = 0.1f;
            }
        }
        else
        {
            OnParentDisabled();
        }
    }
}
