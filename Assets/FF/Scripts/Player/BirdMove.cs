using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BirdMove : MonoBehaviour
{
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private float _speed;
    [SerializeField] private float _tapForce = 10;

    private Rigidbody2D _rigidBody;

    private void Start()
    {
   
        _rigidBody = GetComponent<Rigidbody2D>();

        ResetBird();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _rigidBody.velocity = new Vector2(_speed, 0);
            _rigidBody.AddForce(Vector2.up * _tapForce, ForceMode2D.Force);

        }
    }

    public void ResetBird()
    {
        transform.position = _startPosition;
        _rigidBody.velocity = Vector2.zero;

    }
  
}

