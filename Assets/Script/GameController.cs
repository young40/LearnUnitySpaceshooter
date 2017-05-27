using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject[] Rocks;

	public float startTime;
	public float waveBreakTime;
	public int enemyNumber;
	public Vector3 enemyStart;

	// Use this for initialization
	void Start () {
		StartCoroutine (enemyWaves());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator enemyWaves()
	{
		yield return new WaitForSeconds (startTime);

		while (true) {
			for (int i = 0; i < enemyNumber; i++) {
				Vector3 pos = new Vector3 (Random.Range (-enemyStart.x, enemyStart.x), enemyStart.y, enemyStart.z);
				Instantiate (Rocks [Random.Range(0, Rocks.Length -1)], pos, Quaternion.identity);

				yield return new WaitForSeconds (waveBreakTime);
			}
		}
	}
}
