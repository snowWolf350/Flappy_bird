using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    float _spawnTimer = 3.5f;
    float _spawnTimerMax = 3;

    float _pipeMaxHeight = 0.28f;

    public GameObject _pipeGameobject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _spawnTimer += Time.deltaTime;

        if(_spawnTimer > _spawnTimerMax)
        {
            //spawn pipe
            Vector3 spawnPosition = new Vector3(transform.position.x,Random.Range(-_pipeMaxHeight,_pipeMaxHeight),transform.position.z);
            Instantiate(_pipeGameobject, spawnPosition, Quaternion.identity);
            _spawnTimer = 0;
        }
    }
}
