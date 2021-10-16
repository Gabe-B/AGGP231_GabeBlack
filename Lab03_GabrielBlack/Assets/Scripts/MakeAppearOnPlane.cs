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
    public GameObject content;
    public bool canAppearOnPlane = true;
    public Slider scaleSlider;
    public Slider rotationSlider;

    public float maxScale;
    public float minScale;
    public float rotMin;
    public float rotMax;

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


                    if (!content.activeSelf)
                    {
                        //contentInstance = Instantiate(content, hitPose.position, hitPose.rotation);
                        content.SetActive(true);
                        content.transform.position = new Vector3(hitPose.position.x, hitPose.position.y + 0.5f, hitPose.position.z);
                        content.transform.rotation = hitPose.rotation;
                    }
                    else
                    {
                        //content.GetComponent<Rigidbody>().velocity = Vector3.zero;
                        content.transform.position = new Vector3(hitPose.position.x, hitPose.position.y + 0.5f, hitPose.position.z);
                        content.transform.rotation = hitPose.rotation;
                    }
                }
            }
        }
        else
        {
            content.SetActive(false);
        }
    }

    private void ScaleObject(float value)
    {
        content.transform.localScale = new Vector3(value, value, value);
    }

    private void RotateObject(float value)
    {
        content.transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
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
