using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D _playerRigidBody;
    public float _flapStrength = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerRigidBody.linearVelocity += Vector2.up * _flapStrength;  
        }
    }
}
