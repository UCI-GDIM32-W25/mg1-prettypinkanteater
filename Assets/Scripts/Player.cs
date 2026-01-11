using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5;
    [SerializeField] private GameObject _plantCountUI;
    private Vector3 _movement;
    // [SerializeField] private 

    private int _numSeedsLeft;
    private int _numSeedsPlanted;

    private void Start()
    {
        _numSeedsLeft = _numSeeds;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _playerTransform.position += new Vector3(0, 1, 0) * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            _movement = Vector3.up * -1;
            _playerTransform.position += _movement * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            _playerTransform.position += Vector3.right * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            _playerTransform.position += Vector3.left * _speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }
    }

    public void PlantSeed()
    {
        if (_numSeedsLeft > 0)
        {
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
            _numSeedsPlanted++;
            _numSeedsLeft--;
            Debug.Log(_numSeedsLeft);
            // instantiating 5 at once originally because i used getkey instead of getkeydown which is prolly a difference in holding key down vs simple press

            _plantCountUI.GetComponent<PlantCountUI>().UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);
            Debug.Log("plant count ui");
        }
    }
}
