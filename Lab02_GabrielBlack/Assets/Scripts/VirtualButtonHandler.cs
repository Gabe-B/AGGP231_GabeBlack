using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonHandler : MonoBehaviour
{
    public GameObject vbGrowButton, vbShrinkButton, vbColorButton, vbMegoButton, vbAstleyButton;
	public GameObject shape;
	public Vector3 scaleChange;
	public AudioSource mego, astley;

	int minRange = 0;
	int maxRange = 255;

	void Awake()
	{
		scaleChange = new Vector3(0.25f, 0.25f, 0.25f);
	}

	void Start()
	{
		vbGrowButton = GameObject.Find("GrowButton");
		vbShrinkButton = GameObject.Find("ShrinkButton");
		vbColorButton = GameObject.Find("ColorButton");
		vbMegoButton = GameObject.Find("MegoButton");
		vbAstleyButton = GameObject.Find("AstleyButton");

		vbGrowButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnGrowButtonPressed);
		vbShrinkButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnShrinkButtonPressed);
		vbColorButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnColorButtonPressed);
		vbMegoButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnMegoButtonPressed);
		vbAstleyButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnAstleyButtonPressed);
	}

	public void OnGrowButtonPressed(VirtualButtonBehaviour vb)
	{
		shape.transform.localScale += scaleChange;
	}

	public void OnShrinkButtonPressed(VirtualButtonBehaviour vb)
	{
		shape.transform.localScale += -scaleChange;
	}

	public void OnColorButtonPressed(VirtualButtonBehaviour vb)
	{
		Color c = new Color(Random.value,
							Random.value,
							Random.value);

		shape.gameObject.GetComponent<Renderer>().material.color = c;
	}

	public void OnMegoButtonPressed(VirtualButtonBehaviour vb)
	{
		mego.Play();
	}

	public void OnAstleyButtonPressed(VirtualButtonBehaviour vb)
	{
		astley.Play();
	}

}
