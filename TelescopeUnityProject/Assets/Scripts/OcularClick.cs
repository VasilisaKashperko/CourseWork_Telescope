using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.SceneManagement;

public class OcularClick : MonoBehaviour, IPointerClickHandler
{
    public int tap = 0;

    public void NextToOcularus(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (LabExecute.isBegan && LabExecute.isBeganPart2 == false)
        {
            LabExecute.isOcularOn = true;
            NextToOcularus(1);
        }
        if (LabExecute.isBegan && LabExecute.isSharpnessOK)
        {
            tap += eventData.clickCount;
            if (tap >= 2)
            {
                LabExecute.isOcularOn = true;
                NextToOcularus(2);
            }
        }
    }
}
