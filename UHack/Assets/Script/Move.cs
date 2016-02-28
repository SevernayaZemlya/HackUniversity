using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	public float speed = 5;
	public GameObject text;

	//When the player hits an object
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "has_text")
		{
			text.SetActive (true);
		}
	}

	//When the player stops hitting an object
	void OnCollisionExit (Collision col)
	{
		if (col.gameObject.tag == "has_text")
		{
			text.SetActive (false);
		}
	}

	// Use this for initialization
	void Start ()
	{
		transform.position = new Vector3(0, 0, 0);
		text.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Vector3.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime);
		transform.Translate(Vector3.forward * speed * Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
