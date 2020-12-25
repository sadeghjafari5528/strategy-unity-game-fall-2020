using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class mouse_manager : MonoBehaviour
{
	RaycastHit hit;
	private int raycastLenght = 1000;
	[SerializeField]
	private GameObject town_button;
	// Start is called before the first frame update
	void Start()
	{
		
		}

	// Update is called once per frame
	void Update()
	{
		//mouse_movement();
		mouse_handler_click();

	}
	private void mouse_movement()
	{
		Debug.Log("helloworld");
	}
	private void mouse_handler_click()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast(ray , out hit , raycastLenght))
		{
			if (hit.collider.tag == "town") {

				if (Input.GetMouseButton(0))
				{
					//SceneManager.LoadScene("town_map");
					town_button.SetActive(true);
				}
            }
		}
        else
        {
			if (Input.GetMouseButton(0))
			{
				setAllFalse();
			}
        }
	}
	private void setAllFalse()
    {
		town_button.SetActive(false);
	}
}

