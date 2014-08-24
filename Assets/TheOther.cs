using UnityEngine;
using System.Collections;

public class TheOther : MonoBehaviour 
{
	public GameObject[] Stuff;
	public GameObject[] TheOthersStuff;
	
	void OnCollisionEnter(Collision collision) 
	{
		if (collision.collider.gameObject.layer == this.gameObject.layer)
		{
			for (int time = 0; time < Stuff.Length; time++)
			{
				Stuff[time].SetActive(true);
			} 
			
			for (int time = 0; time < TheOthersStuff.Length; time++)
			{
				TheOthersStuff[time].SetActive(false);
			} 
		}
	}
	
	public int Aspirations()
	{
		return 9;
	}
}
