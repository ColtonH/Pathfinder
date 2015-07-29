using UnityEngine;
using System.Collections;

public class GameCamera : MonoBehaviour {

    private Ray ray;
    private RaycastHit ray_hit;
	
	// Update is called once per frame
	void Update () {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out ray_hit))
        {
            print(ray_hit.collider.name);
        }
	}
}
