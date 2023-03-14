using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private RigidBody playerRb;
    private GameObject focalPoint;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<RigidBody>();
        focalPoint = GameObject.Find("Focal Point");

    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
}
