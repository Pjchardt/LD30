using UnityEngine;
using System.Collections;

public class _Doorway_ : MonoBehaviour 
{
	public GameObject TheFirstOfTwo;
	 
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			TheFirstOfTwo.SetActive(true);
			this.gameObject.SetActive(false);
		}
	}
}
