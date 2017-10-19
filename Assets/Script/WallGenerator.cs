using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
	public GameObject wallPrefab;
	public float interval;

	public float range = 3.0f;

    // Use this for initialization
    IEnumerator Start()
    {
		// コルーチン処理
		while(true)
		{
			// 生成ポイントをランダムにする
			transform.position = new Vector3(transform.position.x, Random.Range(-range, range), transform.position.z);

			Instantiate(wallPrefab, transform.position, transform.rotation);
			// intervalの時間、処理を中断
			yield return new WaitForSeconds(interval);
		}
    }

    // Update is called once per frame
    void Update()
    {

    }
}
