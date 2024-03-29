﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GeneralUI;

public class FadeToBlack : MonoBehaviour
{ 
    public Image BlackIm;

    void Start()
    {
        StartCoroutine(Attendi());
        
    }

    void FadeIn()
    {
        BlackIm.CrossFadeAlpha(1, 2, false);
    }

    IEnumerator Attendi()
    {
        yield return new WaitForSeconds(1);
        BlackIm.CrossFadeAlpha(0, 1, false);
    }

}
