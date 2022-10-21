using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static float Speed;
    public static float Range;

    public GameObject cube;
    private Vector3 _target;

    void Start()
    {
        _target = new Vector3(transform.position.x + Range, 0, 0);
    }

    
    void Update()
    {
        cube.transform.position = Vector3.MoveTowards(transform.position, _target, Speed * Time.deltaTime);
        if (transform.position == _target)
          {
              Destroy(cube);
          }
    }
}
