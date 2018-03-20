using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToRandomPosition : MonoBehaviour {

    public Transform _objectToMove;
    public Transform _player;
    public float _movingRange=10;
    public float _decreasingRange = 2;
    public float _timeBeforeMoving=5f;
    public float _height = 5;
    public float _downHeight = -3;

    public Vector3 _destination;

	void Start () {
        _player =  GameObject.FindObjectOfType<Camera>().transform;
        InvokeRepeating("ResetPosition", 0, _timeBeforeMoving);
	}

    void ResetPosition() {

        _destination = _player.position;
        Vector3 randomAdjustement = new Vector3();

        randomAdjustement.x = Random.Range(-_movingRange, _movingRange);
        randomAdjustement.z = Random.Range(-_movingRange, _movingRange);
        randomAdjustement.y = Random.Range(_downHeight, _height);

        _destination += randomAdjustement;
        _movingRange -= _decreasingRange;
        if (_movingRange < 0)
            _movingRange = 0;




    }

	
	// Update is called once per frame
	void Update () {
        
        _objectToMove.position = Vector3.Lerp(_objectToMove.position, _destination, Time.deltaTime);
    }
}
