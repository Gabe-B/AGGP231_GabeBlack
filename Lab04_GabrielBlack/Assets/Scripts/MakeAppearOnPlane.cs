using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Experimental.XR;
using UnityEngine.EventSystems;

public class MakeAppearOnPlane : MonoBehaviour
{
    public GameObject content;
    public bool CanAppearOnPlane = true;
    public Slider scaleSlider;
    public Slider rotationSlider;
    public float maxScale;
    public float minScale;
    public float rotMin;
    public float rotMax;

    // Start is called before the first frame update
    void Start()
    {
        scaleSlider.maxValue = maxScale;
        scaleSlider.minValue = minScale;
        scaleSlider.onValueChanged.AddListener(ScaleObject);

        rotationSlider.maxValue = rotMax;
        rotationSlider.minValue = rotMin;
        rotationSlider.onValueChanged.AddListener(RotateObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ScaleObject(float value)
    {
        content.transform.localScale = new Vector3(value, value, value);
    }

    private void RotateObject(float value)
    {
        content.transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }

    bool IsPointerOverUI(Vector2 pos)
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return false;
        }

        PointerEventData eventPos = new PointerEventData(EventSystem.current);
        eventPos.position = new Vector2(pos.x, pos.y);

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventPos, results);

        return results.Count > 0;
    }
}
