﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour {
	public GameObject PauseMenu;
	bool paused;
	bool muted;
	[SerializeField]
	Text mutetext;
	
	
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			paused = !paused;
		}
		
		if (paused)
		{
			PauseMenu.SetActive(true);
			Time.timeScale = 0;
			
		}
		else if (!paused)
		{
			PauseMenu.SetActive(false);
			Time.timeScale = 1;
		}
		
		if (muted)
		{
			AudioListener.volume = 0;
			mutetext.text = "Unmute/Seesiz";
			
		}
		else if (!muted)
		{
			AudioListener.volume = 1;
			mutetext.text = "Mute/Sesli";
			
		}
		
		
	}
	
	public void Resume()
	{
		paused = false;
		
	}
	
	public void MainMenu()
	{
		Application.LoadLevel("ana");
		
	}
	
	public void Save()
	{
		PlayerPrefs.SetInt("currentscenesave", Application.loadedLevel);
		
	}
	
	public void Load()
	{
		Application.LoadLevel(PlayerPrefs.GetInt("currentscenesave"));
	}
	
	public void Mute()
	{
		muted = !muted;
		
	}
	
	public void Quit()
	{
		
		Application.Quit();
	}
}
