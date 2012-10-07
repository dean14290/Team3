using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour {
	
	
	//Character Controller:
	Rigidbody controller = new Rigidbody();
	
	public float CarSpeed;
	
	static int laneState;
	//1 = Left
	//2 = Middle
	//3 = Right
	
	static int sensing;
	
	static Vector3 moveToLocation;
	static bool buttonPressed;
	
	// Use this for initialization
	void Start () {
	controller = GetComponent<Rigidbody>();
	laneState = 2;
	moveToLocation = controller.position;
		sensing = 0;
	}
	
	// Update is called once per frame
	void Update () {
	controller.AddForce(new Vector3(CarSpeed,-100,0));
		
		if (buttonPressed == true)
		{
		sensing++;
		}
		
		if (sensing == 10)
		{
		buttonPressed = false;
			sensing = 0;
		}
			
		if(buttonPressed == false)
		{
			sensing = 0;
		if(laneState == 1) //left
		{
			Debug.Log ("Left");
			moveToLocation = new Vector3(moveToLocation.x,moveToLocation.y,2.5f);
		
			if (Input.GetKey (KeyCode.RightArrow))
			{
					buttonPressed = true;
				laneState = 2;
			}

		}
		else if(laneState == 2) //middle
		{
			Debug.Log ("Middle");
			moveToLocation = new Vector3(moveToLocation.x,moveToLocation.y,0);
			
						if (Input.GetKey (KeyCode.RightArrow))
			{
					buttonPressed = true;
				laneState = 3;
			}
			
						if (Input.GetKey (KeyCode.LeftArrow))
			{
					buttonPressed = true;
				laneState = 1;
			}
			
		}
		else if(laneState == 3) //right
		{
			Debug.Log ("Right");
			moveToLocation = new Vector3(moveToLocation.x,moveToLocation.y,-2.5f);
		
			if (Input.GetKey (KeyCode.LeftArrow))
			{
					buttonPressed = true;
				laneState = 2;
			}
		}
		}
		
		if (controller.position.z < moveToLocation.z)	
		{
			controller.AddForce(new Vector3(0,0,500));
		}
		
		if (controller.position.z > moveToLocation.z)	
		{
			controller.AddForce(new Vector3(0,0,-500));
		}
		
		if (this.transform.position.x >= 103)
		{
		this.transform.position = new Vector3(-101,this.transform.position.y,this.transform.position.z);
		this.CarSpeed += 50;
		}
		
	}
	
	
}
