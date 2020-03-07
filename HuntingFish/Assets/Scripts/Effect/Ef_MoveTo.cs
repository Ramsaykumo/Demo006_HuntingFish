using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ef_MoveTo : MonoBehaviour {

    private GameObject goldCollect;
    public float GoldMoveSpeed = 35f;
	
	void Start () {
        goldCollect = GameObject.Find("GoldCollect");
	}
	
	
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, goldCollect.transform.position, GoldMoveSpeed * Time.deltaTime);
	}
}
