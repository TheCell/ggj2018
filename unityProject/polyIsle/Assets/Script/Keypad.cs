using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keypad : MonoBehaviour
{
	public string currentPassword = "123";
	public string input;
	public string tempInput;
	public int doorNumber = 1;
	public bool isOpen;
	public bool onTrigger;
	public bool keypadScreen;
	public Transform doorHinge;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (input == currentPassword)
		{
			isOpen = true;
		}

		if (isOpen)
		{
			if (doorNumber == 1)
			{
				var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, 90.0f, 0.0f), Time.deltaTime * 100);
				doorHinge.rotation = newRot;
			}
			else if (doorNumber == 2)
			{
				var doorPosition = doorHinge.transform.position + new Vector3(0.0f, -5.0f, 0.0f);
				doorHinge.position = doorPosition;
				doorNumber = 0;
			}
			else if (doorNumber == 3)
			{
				Application.LoadLevel(3);
				doorNumber = 0;
			}
		}
	}

	void OnTriggerEnter(Collider other)
	{
		onTrigger = true;
	}

	void OnTriggerExit(Collider other)
	{
		onTrigger = false;
		keypadScreen = false;
		input = "";
	}

	void OnGUI()
	{
		if (!isOpen)
		{
			if (onTrigger)
			{
				GUI.Box(new Rect(0, 0, 200, 25), "Press 'E' to open keypad");

				if (Input.GetKeyDown(KeyCode.E))
				{
					keypadScreen = true;
					onTrigger = false;
				}
			}

			if (keypadScreen)
			{
				GameObject player = GameObject.FindGameObjectWithTag("Player");
				var fpsController = player.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>();
				fpsController.enabled = false;

				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;

				GUI.Box(new Rect(0, 0, 320, 455), "");
				GUI.Box(new Rect(5, 5, 310, 25), tempInput);
				
				if (GUI.Button(new Rect(5, 35, 100, 100), "7"))
				{
					input += "7";
				}

				if (GUI.Button(new Rect(110, 35, 100, 100), "8"))
				{
					input += "8";
				}

				if (GUI.Button(new Rect(215, 35, 100, 100), "9"))
				{
					input += "9";
				}

				if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
				{
					input += "4";
				}

				if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
				{
					input += "5";
				}

				if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
				{
					input += "6";
				}

				if (GUI.Button(new Rect(5, 245, 100, 100), "1"))
				{
					input += "1";
				}

				if (GUI.Button(new Rect(110, 245, 100, 100), "2"))
				{
					input += "2";
				}

				if (GUI.Button(new Rect(215, 245, 100, 100), "3"))
				{
					input += "3";
				}

				if (GUI.Button(new Rect(5, 350, 100, 100), "C"))
				{
					input = "";
				}

				if (GUI.Button(new Rect(110, 350, 100, 100), "0"))
				{
					input += "0";
				}

				if (GUI.Button(new Rect(215, 350, 100, 100), "OK"))
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Confined;
					fpsController.enabled = true;
					input = "";
					keypadScreen = false;
				}

				tempInput = input;

				if (input == currentPassword)
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Confined;
					fpsController.enabled = true;
				}
			}
		}
	}
}
