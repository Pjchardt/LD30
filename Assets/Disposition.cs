using UnityEngine;
using System.Collections;

public class Disposition : MonoBehaviour 
{
	public enum StateOf {Balance, Discretion, Naivete, Sadness, Perpetuity, Perspective}
	
	public GameObject MentalModalOfAMagicalContraption;
	
	bool sirensSong = false;

	void Start () 
	{
		ItGoesFasterThanYouThink();
	}
	
	void Update () 
	{
		if (sirensSong)
		{
			MentalModalOfAMagicalContraption.transform.Find("SirensSong").gameObject.SetActive(true);
		}
	}
	
	void VoiceOfBalance()
	{
		//this.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezePositionX;
		//this.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
		//this.gameObject.rigidbody.constraints = RigidbodyConstraints.FreezePositionZ;
	}
	
	void VoiceOfDiscretion()
	{
		 //MentalModalOfAMagicalContraption.transform.Find("SongOfTheSouth").gameObject.SetActive(true);
		 //sirensSong = true;
	}
	
	void VoiceOfConfidence()
	{
		MentalModalOfAMagicalContraption.transform.Find("VisionsOfGrandeur").gameObject.layer = GameObject.Find ("Other").GetComponent<TheOther>().Limitations();
	}
	
	void VoiceOfSadness()
	{
		GameObject.Find ("Other").rigidbody.AddForce(Vector3.right * -300f);
		this.gameObject.transform.rotation = Quaternion.identity;
		this.gameObject.rigidbody.angularVelocity = Vector3.zero;
		this.gameObject.rigidbody.constraints = RigidbodyConstraints.None;
		this.gameObject.rigidbody.velocity = Vector3.zero;
	}
	
	void VoiceOfPerpetuity()
	{
		MentalModalOfAMagicalContraption.transform.Find("MouseTrap").gameObject.SetActive(true);
	}
	
	void VoiceOfOrthography ()
	{
		Destroy(MentalModalOfAMagicalContraption);
		Destroy (this.gameObject);
		Debug.Log ("All is lost.  The answer comes in the past, from the clouds."); 
	}
	
	void OnTriggerEnter(Collider voice)
	{
		StateOf StateOfFocus = voice.GetComponent<Voice>().VoiceOf; 
		switch (StateOfFocus)
		{
			case StateOf.Balance:
			VoiceOfBalance ();
			break; 
			case StateOf.Discretion:
			VoiceOfDiscretion ();
			break; 
			case StateOf.Naivete:
			VoiceOfConfidence ();
			break; 
			case StateOf.Sadness:
			VoiceOfSadness ();
			break; 
			case StateOf.Perpetuity:
			VoiceOfPerpetuity ();
			break; 
			case StateOf.Perspective:
			VoiceOfOrthography ();
			break; 
		}
	}
	
	void OnCollisionEnter(Collision collision) 
	{
		if (collision.collider.gameObject.layer == 9)
		{
			this.gameObject.rigidbody.AddForce(Vector3.up * 800f);
		}
	}
	
	void ItGoesFasterThanYouThink()
	{
		Time.timeScale = 2f;
	}
}
