using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    public GameManager gm;
    public TMP_Text btnText;
    public bool clicked = false;
    public void Write(string text)
    {
        btnText.text = text;
        clicked = true;
    }
}
