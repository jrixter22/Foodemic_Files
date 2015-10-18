using UnityEngine;
using System.Collections;

public class createMess : MonoBehaviour 
{
	//public gameObject Mess;
	//public Rigidbody Bullets;
	static double score = 0;

	void Update()
	{
		/*float distance = (Bullets.transform.position - transform.position).magnitude;
		if (distance < 0.1f) 
		{
			//Destroy(Bullets);
		}*/
		//Debug.Log("ping");
//		CharacterController controller = GetComponent < CharacterController > ();
//		if (controller.collisionFlags == CollisionFlags.None)
//			print ("Free floating");
//		if ((controller.collisionFlags & CollisionFlags.Sides) != 0)
//			print ("Touching Sides");
//		if (controller.collisionFlags == CollisionFlags.Sides)
//			print ("Only Touching Sides, Nothing Else");
		//Debug.Log (score);
	}

	void OnCollisionEnter(Collision col)
	{
		//print ("detect");
		score += 0.5;
		Debug.Log (score);
		if (col.gameObject.name == "Cursor") {
			//score += 1;
			Destroy (gameObject);
			//Instantiate("Mess");
		} 
		if (col.gameObject.name == "Target") {
			//score += 1;
			Destroy (gameObject);
		} else if (col.gameObject.name == "Target2") {
			Destroy (gameObject);
		} else if (col.gameObject.name == "Target3") {
			Destroy (gameObject);
		}
			

	}
}
