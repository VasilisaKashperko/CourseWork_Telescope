using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine;

public class FocusedOcular : MonoBehaviour
{
    [SerializeField]
    float scrollSpeed = 80f;

    public GameObject textObject;
    public GameObject textPanel;
    public GameObject textObjectSize;
    public GameObject textPanelSize;

    string taskText = "Приближайте планету до наилучшего увеличения (так, чтобы планета была видна целиком), глядя в окуляр и регулируя искатель при помощи колеса мыши. После чего нажмите кнопку \"Вернуться к установке\".";

    void Start()
    {
        textPanel.SetActive(true);
        if (textObject.TryGetComponent(out TextMeshProUGUI message))
        {
            message.text = taskText;
            message.color = Color.black;
        }
        transform.position = new Vector3(Mathf.Clamp(LabExecute.positionX, -1459, 1449),
                                Mathf.Clamp(LabExecute.positionY, -807, 809),
                                Mathf.Clamp(transform.position.z, -181, 136));
        LabExecute.isSized = false;
    }

    void FixedUpdate()
    {
        if (LabExecute.isOcularOn)
        {
            float x = Input.GetAxis("Mouse ScrollWheel");

            if (x != 0)
            {
                Vector3 newpos = transform.position + (transform.TransformDirection(new Vector3(0, 0, x * scrollSpeed * scrollSpeed)));

                transform.position = newpos;
                transform.position = new Vector3(Mathf.Clamp(LabExecute.positionX, -1459, 1449),
                                                Mathf.Clamp(LabExecute.positionY, -807, 809),
                                                Mathf.Clamp(transform.position.z, -181, 136));
                LabExecute.isSized = true;

                if (transform.position.z < 136)
                {
                    string taskTextSize = "100.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "100.0";
                }

                if (transform.position.z < 104)
                {
                    string taskTextSize = "95.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "95.0";
                }

                if (transform.position.z < 72)
                {
                    string taskTextSize = "90.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "90.0";
                }

                if (transform.position.z < 40)
                {
                    string taskTextSize = "85.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "85.0";
                }

                if (transform.position.z < 9)
                {
                    string taskTextSize = "80.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "80.0";
                }

                if (transform.position.z < -22)
                {
                    string taskTextSize = "75.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "75.0";
                }

                if (transform.position.z < -54)
                {
                    string taskTextSize = "70.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "70.0";
                }

                if (transform.position.z < -85)
                {
                    string taskTextSize = "65.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "65.0";
                }

                if (transform.position.z < -117)
                {
                    string taskTextSize = "60.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "60.0";
                }

                if (transform.position.z < -137)
                {
                    string taskTextSize = "55.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "55.0";
                }

                if (transform.position.z < -159)
                {
                    string taskTextSize = "50.0X";
                    if (textObjectSize.TryGetComponent(out TextMeshProUGUI message))
                    {
                        message.text = taskTextSize;
                        message.color = Color.white;
                    }
                    LabExecute.upsize = "50.0";
                }

                LabExecute.isTheEnd = true;
            }
        }
    }
}
