using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fukidasi : MonoBehaviour
{
	public GameObject fukdiasi;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter2D()
	{
		Instantiate(fukdiasi, this.transform);
	}
}
