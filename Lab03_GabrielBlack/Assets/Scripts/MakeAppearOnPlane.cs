using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MakeAppearOnPlane : MonoBehaviour
{
    public GameObject kyle;
    public bool canAppearOnPlane = true;
    public Slider scaleSlider;
    public Slider rotationSlider;

    public float maxScale;
    public float minScale;
    public float rotMin;
    public float rotMax;

    GameObject kyleInstance;
    ARRaycastManager raycastManager;
    Vector2 touchPos;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();

        scaleSlider.maxValue = maxScale;
        scaleSlider.minValue = minScale;
        scaleSlider.onValueChanged.AddListener(ScaleObject);

        rotationSlider.maxValue = rotMax;
        rotationSlider.minValue = rotMin;
        rotationSlider.onValueChanged.AddListener(RotateObject);
    }

    bool GetTouchPosition(out Vector2 touchPos)
    {
        if (Input.touchCount > 0)
        {
            touchPos = Input.GetTouch(0).position;

            return true;
        }

        touchPos = default;

        return false;
    }

    void Update()
    {
        if (!GetTouchPosition(out Vector2 touchPos))
        {
            return;
        }

        bool isOverUI = IsPointerOverUI(touchPos);

        if (canAppearOnPlane)
        {
            if(!isOverUI)
            {
                if (raycastManager.Raycast(touchPos, hits, TrackableType.PlaneWithinPolygon))
                {
                    var hitPose = hits[0].pose;


                    if (kyleInstance == null)
                    {
                        kyleInstance = Instantiate(kyle, hitPose.position, hitPose.rotation);
                    }
                    else
                    {
                        kyleInstance.transform.position = hitPose.position;
                    }
                }
            }
        }
        else
        {
            Destroy(kyleInstance);
        }
    }

    private void ScaleObject(float value)
    {
        kyleInstance.transform.localScale = new Vector3(value, value, value);
    }

    private void RotateObject(float value)
    {
        kyleInstance.transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }

    public void CanAppearOnPlane()
    {
        if (canAppearOnPlane == true)
        {
            canAppearOnPlane = false;
        }
        else
        {
            canAppearOnPlane = true;
        }
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
