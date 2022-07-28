using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDown : MonoBehaviour
{
	public PlayerLife pl;
	public Vector3 localScale;
	public float max_Time=100, my_Time,my_Level;

	// Use this for initialization
	void Start()
    {
        my_Time = max_Time;
		localScale = transform.localScale;
	}

    // Update is called once per frame
    void Update()
	{
		my_Time -= Time.deltaTime * my_Level;
		localScale.x = my_Time/max_Time;
		transform.localScale = localScale;
		if (my_Time >= 100)
        {
			my_Time = 100;
        }
		if (my_Time <= 0)
		{
			pl.Die();
		}
	}
}