﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "Stage", menuName = "Create Stage Object")]
public class Stage : ScriptableObject 
{
	public int number;
	public string key;
	public string displayName;
	public string scene;
	public StageType type;
	

	public Stage nextStage;
}

[Serializable]
public enum StageType
{
	Normal,
	Cinematic
}

[Serializable]
public class StageInfo
{
	public bool unlocked;
	public int hiveCount;
}