using UnityEngine;
using System.Collections;
using System;

public class Davids : MonoBehaviour 
{
	//once web version is built add in redacted to answer numbers
	public TextMesh [] InputHandles;

	enum SomeCluesForYou {SixNumbers, FindingOasis, ObviousForSome, UnSilenceTheVoicesOfMisdirection, LogicalConclusion}	
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
			string temp = Input.inputString; 
			
			if (temp.Contains("\b"))
			{
				if (InputHandles[(int)current].text.Length > 0)
				{
					ObjectOfLessDiscouragement.audio.Play ();
					InputHandles[(int)current].text = InputHandles[(int)current].text.Substring(0, InputHandles[(int)current].text.Length - 1);
				}
			}
			else if (temp.Contains("\r"))
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
				if (input == "018432")
				{
					ObjectOfEncouragement.audio.Play();
					current = SomeCluesForYou.FindingOasis;
					NewState();
				    niceWork = true;
				}
			break;
			case SomeCluesForYou.FindingOasis:
			if (input == "1818")
			{
				ObjectOfEncouragement.audio.Play();
				current = SomeCluesForYou.ObviousForSome;
				NewState();
				niceWork = true;
			}
			break;
			case SomeCluesForYou.ObviousForSome:
			if (input == "4147")
			{
				ObjectOfEncouragement.audio.Play();
				current = SomeCluesForYou.UnSilenceTheVoicesOfMisdirection;
				NewState();
				niceWork = true;
			}
			break;
			case SomeCluesForYou.UnSilenceTheVoicesOfMisdirection:
			if (input == "5")
			{
				ObjectOfEncouragement.audio.Play();
				current = SomeCluesForYou.LogicalConclusion;
				NewState();
				niceWork = true;
			}
			break;
			case SomeCluesForYou.LogicalConclusion:
			if (input == "30")
			{
				ObjectOfEncouragement.audio.Play();
				TheOtherName.SetActive(true);
				this.gameObject.SetActive(false);
				niceWork = true;
			}
			break;
		}
		
		return niceWork;
	}
	
	void NewState() //51st to be exact :)
	{	
		InputHandles[(int)current].gameObject.transform.parent.gameObject.SetActive(true);
	}
}
