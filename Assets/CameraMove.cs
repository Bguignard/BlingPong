using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    float dep = 0.45f;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.localPosition;
        if (Input.GetKey(KeyCode.Z))
        {
            position.z += dep;
            transform.localPosition = position;
        }
        if (Input.GetKey(KeyCode.D))
        {
            position.x += dep;
            transform.localPosition = position;
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.z -= dep;
            transform.localPosition = position;
            
        }
        if (Input.GetKey(KeyCode.Q))
        {
            position.x -= dep;
            transform.localPosition = position;
        }
    }
}
