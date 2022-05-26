using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1Script : MonoBehaviour
{
	[SerializeField] GameObject _playerKey;
	[SerializeField] GameObject _camera;

	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		string playerTag = otherCollider.gameObject.tag;

		// is the other object a player?
		if (playerTag == "Pickup")
		{
			Instantiate(_playerKey,this.gameObject.transform.position,Quaternion.identity);
			_camera.SetActive(false);
			this.gameObject.SetActive(false);
			// then destroy this object
			//this.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0,0);
		}
	}
}
