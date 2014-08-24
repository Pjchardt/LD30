using UnityEngine;
using System.Collections;
using System;

//Thank you for playing.  Unfortunately, a number of lines of code were forced to be redacted at the request of David.  I sincerely apologize for
//the incovenience. -Mgmt

public class Davids : MonoBehaviour 
{
	public TextMesh [] InputHandles;

	enum SomeCluesForYou {SixNumbers, FindingOasis, ObviousForSome, Misdirection, LogicalConclusion}	
	SomeCluesForYou current = SomeCluesForYou.SixNumbers;
	
	public GameObject ObjectOfEncouragement;
	public GameObject ObjectOfDiscouragement;
	public GameObject ObjectOfLessEncouragement;
	public GameObject ObjectOfLessDiscouragement;
	
	public GameObject TheOtherName;
	
	void Start()
	{
		for (int i = 0; i < InputHandles.Length; i++)
		{
			InputHandles[i].gameObject.transform.parent.gameObject.SetActive(false);
		}
			
		NewState ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.inputString.Length > 0)
		{
			string yourImpact = Input.inputString; 
			
			if (yourImpact.Contains("\b"))
			{
				if (InputHandles[(int)current].text.Length > 0)
				{
					ObjectOfLessDiscouragement.audio.Play ();
					InputHandles[(int)current].text = InputHandles[(int)current].text.Substring(0, InputHandles[(int)current].text.Length - 1);
				}
			}
			else if (yourImpact.Contains("\r"))
			{
				if (!CheckInput(InputHandles[(int)current].text))
				{
					InputHandles[(int)current].text = "";
					ObjectOfDiscouragement.audio.Play();
				}
			}
			else
			{
				InputHandles[(int)current].text += Input.inputString;
				ObjectOfLessEncouragement.audio.Play();
				if (InputHandles[(int)current].text.Length > 6)
				{
					InputHandles[(int)current].text = InputHandles[(int)current].text.Substring(0, 6);
				}
			}
		}
	}
	
	bool CheckInput(string input)
	{
		bool niceWork = false;
		switch (current)
		{
			case SomeCluesForYou.SixNumbers:
			//REDACTED
			break;
			case SomeCluesForYou.FindingOasis:
			//REDACTED
			break;
			case SomeCluesForYou.ObviousForSome:
			//REDACTED
			break;
			case SomeCluesForYou.Misdirection:
			//REDACTED
			break;
			case SomeCluesForYou.LogicalConclusion:
			//REDACTED
			break;
		}
		
		return niceWork;
	}
	
	void NewState() //51st to be exact :)
	{	
		//REDACTED
	}
}
