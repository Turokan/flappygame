﻿using UnityEngine;
using System.Collections;

public class MoveOffset : MonoBehaviour {

	private Material currentMaterial;
	public float speed;
	private float offset;
	GameControler gameControler;
	// Use this for initialization
	void Start () {
		currentMaterial =renderer.material;
		gameControler = FindObjectOfType(typeof(GameControler))as GameControler;    
	}
	
	// Update is called once per frame
	void Update () {
		if(gameControler.getCurentState() != GameStates.INGAME)
			return;

		offset += 0.001f;
		currentMaterial.SetTextureOffset("_MainTex",new Vector2(offset*speed,0));
	}
}
