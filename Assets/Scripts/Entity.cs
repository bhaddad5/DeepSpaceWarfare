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
			currentSpeed = PhysicsHelpers.RecalculateVOverTime(currentSpeed, transform.position, MassKg, parent.transform.position, parent.MassKg, GameController.TimeConstant);
			transform.position += currentSpeed;
		}
	}
}
