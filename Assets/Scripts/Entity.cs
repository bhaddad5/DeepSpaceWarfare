using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
	public double MassKg;

	[SerializeField] private Entity parent;
	[SerializeField] private Vector3 currentSpeed;
	
	// Update is called once per frame
	void Update ()
	{
		if (parent != null)
		{
			float dist = parent.transform.position.FromTo(transform.position).magnitude;

			//Debug.Log(dist);

			float gravity = (float)(PhysicsHelpers.GravitationalConstant * ((MassKg * parent.MassKg) / (dist * dist)));

			//Debug.Log(gravity);

			Vector3 gravityDirection = transform.position.FromTo(parent.transform.position).normalized;

			Vector3 gravityVector = gravityDirection * gravity;

			//Debug.Log(gravityVector.ToString("f8"));

			currentSpeed = currentSpeed + gravityVector;

			transform.position += currentSpeed;
		}
	}
}
