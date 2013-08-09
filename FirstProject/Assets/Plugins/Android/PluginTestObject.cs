using UnityEngine;
using System.Collections;

public class PluginTestObject : MonoBehaviour
{

	// Use this for initialization
	void Start () {
		
		AndroidJavaObject jo = new AndroidJavaObject("PluginTest", 0);
		
		jo.Call<int>("GetValue");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
