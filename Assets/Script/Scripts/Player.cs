using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public TimeDown time;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("Trap"))
		{
			TakeTimeDamage(20);
		}
	}

	public void TakeTimeDamage(float timeDamage)
	{
		time.my_Time -= timeDamage;
	}
	public void TakeTime(float timeDamage)
	{
		time.my_Time += timeDamage;
	}

}