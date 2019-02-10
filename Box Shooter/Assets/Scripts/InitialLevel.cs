using UnityEngine;
using System.Collections;

namespace AssemblyCSharp
{
	public class InitialLevel : MonoBehaviour {

		// respond on collisions
		void OnCollisionEnter(Collision newCollision)
		{
			// only do stuff if hit by a projectile
			if (newCollision.gameObject.tag == "Projectile") {
				// call the NextLevel function in the game manager
				GameManager.gm.InitialLevel();
			}
		}
	}
}

