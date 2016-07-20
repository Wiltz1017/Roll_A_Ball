using UnityEngine;
using System.Collections;

public class obsticle : MonoBehaviour {
	
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate (new Vector3 (0, 0, 80) * Time.deltaTime);
	}
}
