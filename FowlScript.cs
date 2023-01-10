using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FowlScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool fowlIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && fowlIsAlive == true)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }

        if (transform.position.y < -25)
        {
            logic.gameOver();
            fowlIsAlive = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        fowlIsAlive = false;
    }
}
