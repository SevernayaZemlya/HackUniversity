using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	public float speed = 5;
	
	//When the player hits an object
	void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            Destroy(col.gameObject);
        }
    }
	
	// Use this for initialization
	void Start ()
	{
		transform.position = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(Vector3.right * speed * Input.GetAxis("Horizontal") * Time.deltaTime);
		transform.Translate(Vector3.forward * speed * Input.GetAxis("Vertical") * Time.deltaTime);
	}
}
