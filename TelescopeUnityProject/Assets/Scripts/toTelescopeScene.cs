using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;
using TMPro;

public class toTelescopeScene : MonoBehaviour, IPointerClickHandler
{
    public UnityEngine.UI.Dropdown planetNameDrop;

    public void NextToOcularus(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (LabExecute.isOcularOn)
        {
            LabExecute.isPlanetFounded = true;

            string name;
            float sharpness;
            float distance;
            float diameter;

            switch (planetNameDrop.value)
            {
                case 0:
                    name = "Венера";
                    distance = 41.4f;
                    diameter = 12104f;
                    sharpness = Convert.ToSingle(diameter / (2 * Math.Pow(distance, 2))); // 3.5
                    break;
                case 1:
                    name = "Меркурий";
                    distance = 91.6f;
                    diameter = 4879f;
                    sharpness = Convert.ToSingle(10 * diameter / (2 * Math.Pow(distance, 2))); // 2.9
                    break;
                case 2:
                    name = "Марс";
                    distance = 75.3f;
                    diameter = 6794f;
                    sharpness = Convert.ToSingle(10 * diameter / (2 * Math.Pow(distance, 2))); // 6.0
                    break;
                case 3:
                    name = "Уран";
                    distance = 2721.4f;
                    diameter = 51118f;
                    sharpness = Convert.ToSingle(1000 * diameter / (2 * Math.Pow(distance, 2))); // 3.5
                    break;
                case 4:
                    name = "Нептун";
                    distance = 4347.4f;
                    diameter = 49528f;
                    sharpness = Convert.ToSingle(1000 * diameter / (2 * Math.Pow(distance, 2))); // 1.3
                    break;
                case 5:
                    name = "Сатурн";
                    distance = 1277.4f;
                    diameter = 120536f;
                    sharpness = Convert.ToSingle(100 * diameter / (2 * Math.Pow(distance, 2))); // 3.7
                    break;
                case 6:
                    name = "IOпитер";
                    distance = 628.4f;
                    diameter = 142984f;
                    sharpness = Convert.ToSingle(10 * diameter / (2 * Math.Pow(distance, 2))); // 1.8
                    break;
                default:
                    name = "Венера";
                    distance = 41.4f;
                    diameter = 12104f;
                    sharpness = Convert.ToSingle(diameter / (2 * Math.Pow(distance, 2))); // 3.5
                    break;
            }

            LabExecute.planetName = name;
            LabExecute.valueSharp = $"{sharpness:f1}";
            LabExecute.valueMass = $"{distance:f1}";
            LabExecute.valueDiameter = $"{diameter:f1}";
            LabExecute.isBeganPart2 = true;

            NextToOcularus(0);
        }
    }
}
