using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    float dep = 0.45f;
    Rigidbody m_rigidbody;

    // Use this for initialization
    void Start () {
        m_rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = transform.localPosition;
        if (Input.GetKey(KeyCode.Z))
        {
            position.z += dep;
            m_rigidbody.MovePosition(position);
            //transform.localPosition = position;
        }
        if (Input.GetKey(KeyCode.D))
        {
            position.x += dep;
            m_rigidbody.MovePosition(position);
            //transform.localPosition = position;
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            position.z -= dep;
            m_rigidbody.MovePosition(position);
            //transform.localPosition = position;
            
        }
        if (Input.GetKey(KeyCode.Q))
        {
            position.x -= dep;
            m_rigidbody.MovePosition(position);
            //transform.localPosition = position;
        }
    }
}
