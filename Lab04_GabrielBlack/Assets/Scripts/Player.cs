using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Experimental.XR;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;
using UnityEngine.XR.ARSubsystems;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region Move Methods
    public void MoveForwards()
    {
        rb.velocity = Vector3.zero;
        rb.velocity += (gameObject.transform.forward * moveSpeed);
    }

    public void MoveBackwards()
    {
        rb.velocity = Vector3.zero;
        rb.velocity += (-gameObject.transform.forward * moveSpeed);
    }

    public void MoveLeft()
    {
        rb.velocity = Vector3.zero;
        rb.velocity += (-gameObject.transform.right * moveSpeed);
    }

    public void MoveRight()
    {
        rb.velocity = Vector3.zero;
        rb.velocity += (gameObject.transform.right * moveSpeed);
    }
    #endregion
}
