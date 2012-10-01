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
		
		if (Input.GetKey (KeyCode.RightArrow))
		{
		controller.AddForce(new Vector3(0,0,-100));
		}
		
	
		if (Input.GetKey (KeyCode.LeftArrow))
		{
		controller.AddForce(new Vector3(0,0,100));
		}
		
		if (this.transform.position.x >= 103)
		{
		this.transform.position = new Vector3(-101,this.transform.position.y,this.transform.position.z);
		this.CarSpeed += 10;
		}
		
	}
	
	
}
