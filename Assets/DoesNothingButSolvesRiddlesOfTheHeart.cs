using UnityEngine;
using System.Collections;

public class DoesNothingButSolvesRiddlesOfTheHeart : MonoBehaviour 
{
	int riddlesOfTheHeart = 0;
	int key = 0;
	int heart = 381;
	
	int seedOfMyHeart = 5;
	
	void Start () 
	{
		Random.seed = seedOfMyHeart;
	}
	
	void Update () 
	{
		if (riddlesOfTheHeart < 1000)
		{
			int experience = (int)(Random.value * 10f);
			key += experience;
			
			riddlesOfTheHeart++;
		}
	}
}
