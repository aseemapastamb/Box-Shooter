using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicFloorMover : MonoBehaviour
{
	private float speed = 0.05f;
	private bool up = true;
	private Vector3 initial = new Vector3(0.0f, -2.0f, 0.0f);
	private Vector3 final = new Vector3(0.0f, 10.0f, 0.0f);
	
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
		if (up)
		{
			gameObject.transform.Translate(Vector3.up * speed);
			if (Vector3.Distance(transform.position, final) < 0.001f)
			{
				up = false;
			}
		}
		else
		{
			gameObject.transform.Translate(Vector3.up * -1.0f * speed);
			if (Vector3.Distance(transform.position, initial) < 0.001f)
			{
				up = true;
			}
		}
    }
}