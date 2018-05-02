using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    protected float baseXPosition = 32.16f;
    protected float baseYPosition = 0.5f;
    protected float baseZPosition = 26.96f;
    protected Vector3 initialVector;

    // Use this for initialization
    void Start()
    {
        initialVector = new Vector3(baseXPosition, baseYPosition, baseZPosition);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("bord"))
        {
            GameObject obj = Resources.Load<GameObject>("Explosion");
            if ( obj != null)
            {
                obj = Instantiate(obj);
                obj.transform.position = collision.contacts[0].point;

                Destroy(obj, 4);
            }
        }

        if (collision.gameObject.name == "cages1")
        {
            Score.addPlayer2Score(1);
            Reset();

        }
        else if (collision.gameObject.name == "cages2")
        {
            Score.addPlayer1Score(1);
            Reset();
        }

    }

    private void Reset()
    {
        transform.position = initialVector;
        GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}