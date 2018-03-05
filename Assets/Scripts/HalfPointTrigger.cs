using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HalfPointTrigger : MonoBehaviour {

	public GameObject LapCompleteTrigger;
	public GameObject HalfLapTrigger;
	

	void OnTriggerEnter () {
		LapCompleteTrigger.SetActive (true);
		HalfLapTrigger.SetActive (false);
	}
}
