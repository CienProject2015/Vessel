﻿using UnityEngine;
using System.Collections;

public class BattleStart : MonoBehaviour {
	void StartBattle(){
		Application.LoadLevel("BattleScene");
	}


	void GoLaboratory(){
		Application.LoadLevel("LaboratoryScene");
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
