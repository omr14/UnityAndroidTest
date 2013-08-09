using UnityEngine;
using System.Collections;

public class ChildCreater : MonoBehaviour
{
	private GameObject parentObj;

	// Use this for initialization
	void Start ()
	{
		parentObj = GameObject.Find("Parent");	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if ( Input.GetKeyDown( KeyCode.Space ) )
		{
			CreateChild();		
		}
	}
	
	void CreateChild ()
	{
		GameObject childObj = (GameObject)Resources.Load("ChildSphere");
		var obj = (GameObject)Instantiate(childObj, transform.position, transform.rotation);
		// childObj.AddComponent<Rigidbody>();
		// childTrans.rigidbody.useGravity = true;
		obj.transform.parent = parentObj.transform;
		
		Vector3 direction = Vector3.up;

		// childObj.rigidbody.velocity = new Vector3( 0.0f, 10.0f, 0.0f );
		obj.rigidbody.AddForce( direction * 10.0f , ForceMode.VelocityChange);
	}
}
