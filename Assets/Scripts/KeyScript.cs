using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string playerTag = otherCollider.gameObject.tag;

		// is the other object a player?
		if (playerTag == "Player")
		{
			transform.parent = GameObject.Find("player").transform;
		}
	}
}
