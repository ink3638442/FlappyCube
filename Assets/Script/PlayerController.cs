using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float jumpPower;
	
	private Rigidbody rd;

	private GameObject go;

	AudioSource se;
	AudioClip jumpSE;


    // Use this for initialization
    void Start()
    {
		this.rd = GetComponent<Rigidbody>();
		this.go = GameObject.Find("Canvas");
		
		this.se = GetComponent<AudioSource>();
		this.jumpSE = this.se.clip;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Jump"))
		{
			this.rd.velocity = new Vector3(0, jumpPower, 0);
			this.se.PlayOneShot(jumpSE, 0.1f);
		}
    }

	void OnCollisionEnter(Collision other)
	{
		// ゲームオーバーメソッドの呼び出し
		this.go.GetComponent<UIController>().GameOver();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "ScoreTrigger")
		{
			// 得点メソッドの呼び出し
			this.go.GetComponent<UIController>().Score();
		}
	}
}
