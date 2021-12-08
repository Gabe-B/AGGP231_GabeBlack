using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Experimental.XR;
using UnityEngine.EventSystems;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;
    public Transform spawnPoint;
    public float groundCheckDist = 1.5f;
    public float groundCheckDeadzone = 0.05f;
    public bool groundCheck;
    public float playerGrav = -9.81f;
    public float stepHeight = 0.1f;

    [SerializeField]
    private bool forwards;
    [SerializeField]
    private bool backwards;
    [SerializeField]
    private bool right;
    [SerializeField]
    private bool left;

    // Start is called before the first frame update
    void Start()
    {
        forwards = false;
        backwards = false;
        right = false;
        left = false;
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        rb.useGravity = false;

        checkForGround();

        if(!groundCheck)
		{
            rb.useGravity = true;
            Physics.gravity = new Vector3(0, playerGrav, 0);
        }

        if(forwards)
		{
            rb.velocity = Vector3.zero;
            rb.velocity += (gameObject.transform.forward * moveSpeed * Time.deltaTime);
        }
        if(backwards)
		{
            rb.velocity = Vector3.zero;
            rb.velocity += (-gameObject.transform.forward * moveSpeed * Time.deltaTime);
        }
        if(right)
		{
            rb.velocity = Vector3.zero;
            rb.velocity += (gameObject.transform.right * moveSpeed * Time.deltaTime);
        }
        if(left)
		{
            rb.velocity = Vector3.zero;
            rb.velocity += (-gameObject.transform.right * moveSpeed * Time.deltaTime);
        }

        if(gameObject.transform.position.y <= 0f)
		{
            rb.velocity = Vector3.zero;
            gameObject.transform.position = spawnPoint.position;
		}
    }

    public void checkForGround()
    {
        //Turn off if jumping

        RaycastHit hit;
        bool result = Physics.Raycast(gameObject.transform.position, Vector3.down, out hit, groundCheckDist);
        groundCheck = result;

        if (result)
        {
            if (hit.distance < groundCheckDeadzone)
            {
                return;
            }

            if (hit.distance < stepHeight)
            {
                gameObject.transform.position = hit.point;
            }
        }
    }

    #region Move Methods
    public void MoveForwardsDown()
    {
        forwards = true;
        /*
            rb.velocity = Vector3.zero;
            rb.velocity += (gameObject.transform.forward * moveSpeed);
        */
    }

    public void MoveForwardsUp()
    {
        forwards = false;
        /*
            rb.velocity = Vector3.zero;
            rb.velocity += (gameObject.transform.forward * moveSpeed);
        */
    }

    public void MoveBackwardsDown()
    {
        backwards = true;
        /*
        rb.velocity = Vector3.zero;
        rb.velocity += (-gameObject.transform.forward * moveSpeed);
        */
    }

    public void MoveBackwardsUp()
    {
        backwards = false;
        /*
        rb.velocity = Vector3.zero;
        rb.velocity += (-gameObject.transform.forward * moveSpeed);
        */
    }

    public void MoveLeftDown()
    {
        left = true;
        /*
        rb.velocity = Vector3.zero;
        rb.velocity += (-gameObject.transform.right * moveSpeed);
        */
    }

    public void MoveLeftUp()
    {
        left = false;
        /*
        rb.velocity = Vector3.zero;
        rb.velocity += (-gameObject.transform.right * moveSpeed);
        */
    }

    public void MoveRightDown()
    {
        right = true;
        /*
        rb.velocity = Vector3.zero;
        rb.velocity += (gameObject.transform.right * moveSpeed);
        */
    }

    public void MoveRighUp()
    {
        right = false;
        /*
        rb.velocity = Vector3.zero;
        rb.velocity += (gameObject.transform.right * moveSpeed);
        */
    }
    #endregion
}
