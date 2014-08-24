using UnityEngine;
using System.Collections;

public class TheOther : MonoBehaviour 
{
	public GameObject[] Stuff;
	public GameObject[] TheOthersStuff;
	
	bool taking = false;
	bool leaving = true;
	
	void OnCollisionEnter(Collision collision) 
	{
		if (collision.collider.gameObject.layer == this.gameObject.layer)
		{
			for (int time = 0; time < Stuff.Length; time++)
			{
				Stuff[time].SetActive(leaving);
			} 
			
			for (int time = 0; time < TheOthersStuff.Length; time++)
			{
				TheOthersStuff[time].SetActive(taking);
			} 
		}
	}
	
	public int Aspirations()
	{
		return 9;
	}
	
	public int Limitations()
	{
		return 1;
	}
}
