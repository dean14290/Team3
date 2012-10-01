using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour {
	
	
	//Character Controller:
	Rigidbody controller = new Rigidbody();
	
	public float CarSpeed;
	
	// Use this for initialization
	void Start () {
	controller = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
	controller.AddForce(new Vector3(CarSpeed,0,0));
	}
}
