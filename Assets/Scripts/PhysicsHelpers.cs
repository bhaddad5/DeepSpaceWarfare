using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PhysicsHelpers
{
	//kg m seconds
	public const double GravitationalConstant = 6.67408e-11;

	public static Vector3 RecalculateVOverTime(Vector3 v, Vector3 myPos, double myMass, Vector3 parentPos, double parentMass,
		float timespanSeconds)
	{
		float dist = parentPos.FromTo(myPos).magnitude;

		float gravity = (float)(PhysicsHelpers.GravitationalConstant * ((myMass * parentMass) / (dist * dist)));

		Vector3 gravityDirection = myPos.FromTo(parentPos).normalized;

		Vector3 gravityVector = gravityDirection * gravity;

		return (v + gravityVector) * timespanSeconds;
	}
}
