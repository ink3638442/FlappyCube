using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float jumpPower;
	
	private Rigidbody rd;

    // Use this for initialization
    void Start()
    {
		this.rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Jump"))
		{
			this.rd.velocity = new Vector3(0, jumpPower, 0);
		}
    }
}
