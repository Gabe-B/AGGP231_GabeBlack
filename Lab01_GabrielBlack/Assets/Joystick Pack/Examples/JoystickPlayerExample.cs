using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class JoystickPlayerExample : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public VariableJoystick variableJoystick;
    public Rigidbody rb;
    public Button jumpButton;

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
            SceneManager.LoadScene(1);
		}
    }

    void Jump()
	{
        rb.AddForce(Vector3.up * jumpForce * Time.fixedDeltaTime, ForceMode.Impulse);
	}
}