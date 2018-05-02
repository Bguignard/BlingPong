using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{
    float dep = 0.45f;
    Rigidbody m_rigidbody;

    // Use this for initialization
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.localPosition;
        if (Input.GetKey(KeyCode.Keypad8))
        {
            position.z += dep;
            m_rigidbody.MovePosition(position);
            //transform.localPosition = position;
        }
        if (Input.GetKey(KeyCode.Keypad6))
        {
            position.x += dep;
            m_rigidbody.MovePosition(position);
            //transform.localPosition = position;

        }
        if (Input.GetKey(KeyCode.Keypad5))
        {
            position.z -= dep;
            m_rigidbody.MovePosition(position);
            //transform.localPosition = position;

        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            position.x -= dep;
            m_rigidbody.MovePosition(position);
            //transform.localPosition = position;
        }
    }
}
