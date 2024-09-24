using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class MovementComponent : MonoBehaviour
{
    [SerializeField] private GameObject otherGameObject;
    private Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 DirectionToMove = new Vector2
        (
            Input.GetAxis("Horizontal"),
            myRigidBody.velocity.y
        );
        myRigidBody.velocity = DirectionToMove;
    }
}
