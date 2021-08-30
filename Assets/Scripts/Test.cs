using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i = 0; i <= 5; i++) {

			for (int j = 0; j <= 5; j++) {

				if (i == j) {
					if (i >= 3) {
						continue;
					}

				} 

				Debug.Log (i + "," + j);

			}

		}
	}
	
	// Update is called once per frame
	void Update () {
		


	}
}
