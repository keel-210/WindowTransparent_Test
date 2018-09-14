﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectPositionMover : MonoBehaviour
{
	RectTransform tra;
	Vector3 PosOffset;
	float DelayTime;
	float Timer;
	void Start ()
	{
		tra = GetComponent<RectTransform> ();
	}
	void Update ()
	{
		if (Timer < DelayTime)
		{
			Timer += Time.deltaTime;
		}
		else
		{
			tra.position += PosOffset * Time.deltaTime;
		}
	}
}