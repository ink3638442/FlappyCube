using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float jumpPower;
	
	private Rigidbody rd;

	private GameObject go;

    // Use this for initialization
    void Start()
    {
		this.rd = GetComponent<Rigidbody>();
		this.go = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Jump"))
		{
			this.rd.velocity = new Vector3(0, jumpPower, 0);
		}
    }

	void OnCollisionEnter(Collision other)
	{
		// ゲームオーバーメソッドの呼び出し
		this.go.GetComponent<UIController>().GameOver();
	}
}
