using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public Button jumpButton;
    public float jumpForce;
    public GameObject startPos;

    void Start()
    {
        Button jButton = jumpButton.GetComponent<Button>();
        jButton.onClick.AddListener(Jump);
    }

    public void FixedUpdate()
    {
        Vector3 direction = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);

        if(gameObject.transform.position.y <= -5.0f)
        {
            gameObject.transform.position = startPos.transform.position;
            rb.velocity = Vector3.zero;
        }
    }

    void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
    }
}