using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIMenuAnimation : MonoBehaviour {
	public GameObject panel;
	Animator panelAnimation;
	// Use this for initialization
	void Start () {
		panelAnimation = panel.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//this for settings button
	public void OnClickSettings() {
		Debug.Log("Settings Button Clicked");
		panel.SetActive(true);
		//Open Panel Animation
		panelAnimation.SetInteger("isOpen", 1);

	}

	//this for panels close button
	public void OnPanelCloseButton()
	{
		//close panel animation
		panelAnimation.SetInteger("isOpen", 0);
	}
}
