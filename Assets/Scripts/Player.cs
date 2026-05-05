using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D _playerRigidBody;
    public float _flapStrength = 0.5f;
    public float _yBounds = 0.7f;

    public ScoreUI _scoreUi;
    public GameObject _retryButton;
    public AudioSource _audioSource;
    public AudioClip _scoreSFX;

    bool _playerIsDead = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _playerIsDead == false)
        {
            _playerRigidBody.linearVelocity += Vector2.up * _flapStrength;  
        }
        if(transform.position.y >= _yBounds || transform.position.y <= -_yBounds)
        {
            _playerIsDead = true;
            _retryButton.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("trigger"))
        {
            //update score
            _scoreUi.UpdateScore();
            _audioSource.PlayOneShot(_scoreSFX);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pipe"))
        {
            _playerIsDead = true;
            _retryButton.SetActive(true);
        }
    }
}
