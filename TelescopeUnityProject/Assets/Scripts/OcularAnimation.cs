using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;
using TMPro;
using System.Threading;

public class OcularAnimation : MonoBehaviour
{
    public GameObject ocularus;

    [SerializeField]
    int sensivity = 1;
    float x = 0;

    [SerializeField]
    private Text sharpnessT;
    [SerializeField]
    private Text sharpnessT2;
    [SerializeField]
    private Text sharpnessT3;
    [SerializeField]
    private Text sharpnessT4;
    [SerializeField]
    private Text sharpnessT5;
    [SerializeField]
    private Text sharpnessT6;

    public GameObject textObjectSharpen;
    public GameObject textObject;

    void FixedUpdate()
    {
        if (LabExecute.isBeganPart2)
        {
            if (LabExecute.isSharpnessCheck == false)
            {
                if (Input.GetMouseButton(0))
                {
                    ocularus.transform.Rotate(0.0f, 0.0f, Input.GetAxis("Mouse Y") * sensivity, Space.Self);

                    x += Input.GetAxis("Mouse Y") * sensivity * -1 / 36.0f;

                    if (x > 9.9f)
                    {
                        x = 0.0f;
                    }

                    if (x < 0.0f)
                    {
                        x = 9.9f;
                    }

                    LabExecute.sharpn = x;

                    string taskSharpness = "Текущее значение регулировки резкости окуляра: " + $"{LabExecute.sharpn:f1} дел.";

                    LabExecute.isSharpness = true;

                    if (textObjectSharpen.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskSharpness;
                        message.color = Color.black;
                    }

                    string y = $"{LabExecute.sharpn:f1}";
                    string z = $"{LabExecute.valueSharp:f1}";

                    if (z.Equals(y))
                    {
                        taskSharpness = "Pезкость настроена! Посмотрите в окуляр, активировав режим обозревания планет двойным щелчком мыши по нему.";
                        LabExecute.printSharp = $"{LabExecute.valueSharp:f1}";

                        if (textObject.TryGetComponent(out TextMeshProUGUI messageOK))
                        {
                            messageOK.text = taskSharpness;
                            messageOK.color = Color.black;
                            LabExecute.isSharpnessCheck = true;
                        }

                        if (LabExecute.experimentsAmount == 0)
                        {
                            sharpnessT.text = LabExecute.printSharp;
                        }

                        if (LabExecute.experimentsAmount == 1)
                        {
                            sharpnessT2.text = LabExecute.printSharp;
                        }

                        if (LabExecute.experimentsAmount == 2)
                        {
                            sharpnessT3.text = LabExecute.printSharp;
                        }

                        if (LabExecute.experimentsAmount == 3)
                        {
                            sharpnessT4.text = LabExecute.printSharp;
                        }

                        if (LabExecute.experimentsAmount == 4)
                        {
                            sharpnessT5.text = LabExecute.printSharp;
                        }

                        if (LabExecute.experimentsAmount == 5)
                        {
                            sharpnessT6.text = LabExecute.printSharp;
                        }
                    }
                }
            }
            if (LabExecute.isSharpnessCheck)
            {
                LabExecute.isSharpnessOK = true;
            }
        }
    }
}
