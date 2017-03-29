using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

	public GameObject bulletPrefab;

	public float fireDelay = 0.25f;
	float coolDownTimer = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		coolDownTimer -= Time.deltaTime;

		if (Input.GetButton ("Fire1") && coolDownTimer <= 0) {
			coolDownTimer = fireDelay;

			Vector3 offset = transform.rotation * new Vector3 (0, 0.5f, 0);

			Instantiate (bulletPrefab, transform.position + offset, transform.rotation);

		}
	}
}
