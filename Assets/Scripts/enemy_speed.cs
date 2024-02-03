using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_speed : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private float _speed;
    private bool hasDelayed = false;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (!hasDelayed)
        {
            StartCoroutine(DelayThenMove());
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, _player.position, 1f * Time.deltaTime);
        }
    }

    IEnumerator DelayThenMove()
    {
        yield return new WaitForSeconds(10);
        hasDelayed = true;
    }
}