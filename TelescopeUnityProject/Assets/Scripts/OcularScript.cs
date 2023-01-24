using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine;

public class OcularScript : MonoBehaviour
{
    [SerializeField]
    float sensivity = 500f;

    public GameObject textObject;
    public GameObject textPanel;

    string taskText = "Найдите планету, управляя оптической трубой телескопа, и разместите её строго по центру для удобного обзора. После чего нажмите кнопку \"Идентификация\". В дальнейшнем двигать оптическую трубу будет запрещено.";

    void Start()
    {
        textPanel.SetActive(true);
        if (textObject.TryGetComponent(out TextMeshProUGUI message))
        {
            message.text = taskText;
            message.color = Color.black;
        }
    }

    void FixedUpdate()
    {
        if (LabExecute.isOcularOn)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            if (x != 0 || y != 0)
            {
                Vector3 newpos = transform.position + ((transform.TransformDirection(new Vector3(x * sensivity * sensivity * sensivity * (float)2.0, 0, 0)) + Vector3.up * (float)2.0 * y * sensivity * sensivity * sensivity));

                transform.position = newpos;
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, -1459, 1449),
                                                Mathf.Clamp(transform.position.y, -807, 809),
                                                Mathf.Clamp(transform.position.z, -181, -181));

                LabExecute.positionX = transform.position.x;
                LabExecute.positionY = transform.position.y;
                LabExecute.positionZ = -181;
            }
        }
    }
}
