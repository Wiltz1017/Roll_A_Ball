using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour 
{	
	public float speed;
	public Text countText;
	public Text WinText;

	private Rigidbody rb;
	private int count;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		WinText.text = "";
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal") * speed;
		float moveVertical = Input.GetAxis ("Vertical") * speed;

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("pickup") || other.gameObject.CompareTag("Emerald")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
	
	}
	void SetCountText ()
	{
		countText.text = "Count:" + count.ToString ();
		if (count >= 144)
		{
			WinText.text = "You Win"; 
		}
	}
}
