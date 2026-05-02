using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float _moveSpeed = 0.35f;
    float _leftBounds = -2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < _leftBounds)
        {
            Destroy(gameObject);
        }

        transform.position -= new Vector3(_moveSpeed * Time.deltaTime,0,0);
    }
}
