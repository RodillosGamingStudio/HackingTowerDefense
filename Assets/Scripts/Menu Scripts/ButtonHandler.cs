using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler/*, IPointerDownHandler*/
{
    private Text text;
    private bool inside = false;
    private float TIME = 0.5f;
    private float timer = 0.5f;

    void Awake()
    {
        text = transform.GetChild(0).GetComponent<Text>();
    }

  public void OnPointerEnter(PointerEventData eventData)
  {
        text = transform.GetChild(0).GetComponent<Text>();
        text.text = ">> " + text.text;
        inside = true;
  }

    public void OnPointerExit(PointerEventData eventData)
    {
        text = transform.GetChild(0).GetComponent<Text>();
        text.text = text.text.Substring(3, text.text.Length - 3);
        inside = false;
    }

    /*public void OnPointerDown(PointerEventData eventData)
    {
        text = transform.GetChild(0).GetComponent<Text>();
        if(text.text[0] != '>')
            text.text = ">> " + text.text;
        
        inside = true;
    }*/

    void Update()
    {
        timer -= Time.deltaTime;
        if (inside && timer <= 0)
        {
            timer = TIME;
            text.enabled = !text.enabled;
        }
        else if (!inside)
        {
            text.enabled = true;
            timer = TIME;
        }
    }
}
