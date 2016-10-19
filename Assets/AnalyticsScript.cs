using UnityEngine;
using System.Collections;
using UnityEngine.Analytics;
using System.Collections.Generic;

public class AnalyticsScript : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		TestPurchase ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void LevelUp()
	{

		Analytics.CustomEvent("gameOver", new Dictionary<string, object>
			{
				{ "newLevel", 2 },
				{ "trigger", "purchase" }

			});
	}

	void TestPurchase()
	{
		Analytics.Transaction("purchaseItem1", 1.0m ,"EUR", "null", "null");

		Analytics.SetUserId ("00000000XX");
		Analytics.SetUserBirthYear (2016);
		Analytics.SetUserGender (Gender.Unknown);
	}
}
