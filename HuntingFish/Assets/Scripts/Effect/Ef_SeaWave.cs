using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ef_SeaWave : MonoBehaviour {

    private Vector3 temp;
    public float WaveTime;
	
	void Start () {
        temp = -transform.position;
	}
	
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, temp, WaveTime * Time.deltaTime);
	}
}
