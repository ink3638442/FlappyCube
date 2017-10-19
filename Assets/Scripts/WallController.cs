using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
	public float speed;

	// Use this for initialization
	void Start()
    {
		// 時間で削除するパターン
		Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
		// speed * Time.deltaTime 一定時間に置ける進む距離を一定にする
		transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}
