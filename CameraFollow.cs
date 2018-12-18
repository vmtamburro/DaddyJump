using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float smoothSpeed = .3f;

	
	// Update is called once per frame
	void LateUpdate() {
		if(target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);

            //to make the movement smooth use lerp. Adds a little jumpiness, bc of late update
            //Lerp did not work, so we are now using SmoothDamp
            //^^ ditched that, watch video later about lerping and SmoothDamp.

        
            transform.position = newPos;
        }
	}
}
