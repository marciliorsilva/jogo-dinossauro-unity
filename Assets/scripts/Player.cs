using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

   Animator animator;
	bool noChao = false;
	float chaoCheckRaio = 0.2f;

	public Transform ChaoCheck;
	public LayerMask OQueEChao;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
	}

	void FixedUpdate()
	{
		noChao = Physics2D.OverlapCircle (ChaoCheck.position, chaoCheckRaio, OQueEChao);

		

	}

	// Update is called once per frame
	void Update () {
		if (noChao && Input.GetButton ("Jump")) {
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, 60));
		}
	}


}
