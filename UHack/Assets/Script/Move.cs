using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	public float speed = 5;
	public int x = 0;
	public int y = 0;
	public int z = 0;
	private Animator animator;
    //public GameObject textIntro;
    //public GameObject textTask1C;
    //public GameObject textTask2C;
   // public GameObject textTask3C;
    public GameObject text;

    private bool isMoving;

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
        isMoving = false;
        animator = this.GetComponent<Animator>();
		transform.position = new Vector3(x, y, z);
		text.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
        
        var vertical = Input.GetAxis("Vertical");
		var horizontal = Input.GetAxis("Horizontal");

        animator.speed = 1;

		if (vertical > 0)
		{
            isMoving = true;
            
            animator.SetInteger("Direction", 2);
            transform.Translate(Vector3.up * speed * vertical * Time.deltaTime);
		}
		else if (vertical < 0)
		{
            isMoving = true;
            
            animator.SetInteger("Direction", 0);
			transform.Translate(Vector3.up * speed * vertical * Time.deltaTime);
		}
		else if (horizontal > 0)
		{
            isMoving = true;
            
            animator.SetInteger("Direction", 3);
			transform.Translate(Vector3.right * speed * horizontal * Time.deltaTime);
		}
		else if (horizontal < 0)
		{
            isMoving = true;
            
            animator.SetInteger("Direction", 1);
			transform.Translate(Vector3.right * speed * horizontal * Time.deltaTime);
		}

        if (vertical == 0 && horizontal == 0)
        {

            isMoving = false;
        }

        if (!isMoving)
        {
            animator.speed = 0;
            
        }

	}
}
