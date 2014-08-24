using UnityEngine;
using System.Collections;

public class AndAFragileMentalState : MonoBehaviour 
{
	Vector3 past;
	Vector3 present;
	Vector3 future;
	
	void Start()
	{
		future = new Vector3(float.NaN, float.NaN, float.NaN);
		present = this.gameObject.transform.position;
		past = present;
	}
	
	void Update () 
	{
		past = present;
		present = this.gameObject.transform.position;;
		future = new Vector3(float.NaN, float.NaN, float.NaN);
		
		if (Vector3.Distance(past, present) > (100f * Time.deltaTime))
		{
			Destroy (this.gameObject);
		}
	}
}
