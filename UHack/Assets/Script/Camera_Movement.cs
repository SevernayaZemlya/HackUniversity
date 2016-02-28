using UnityEngine;
using System.Collections;

public class Camera_Movement : MonoBehaviour
{
	public GameObject player;
	// Use this for initialization
	void Start ()
	{
		transform.position = new Vector3(0, 6, 0);
		transform.rotation = Quaternion.Euler(90, 0, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 6, player.transform.position.z);
	}
}
