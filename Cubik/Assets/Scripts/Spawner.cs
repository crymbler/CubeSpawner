using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float t;
    public static float TimeBetweenRespawn;

    private void Start()
    {

    }

    void Update()
    {
        if ( t <= 0)
        {
            CreateCube();
        }
        else
        {
            t -= Time.deltaTime; 
        }
    }

   public void CreateCube()
    {

        t = TimeBetweenRespawn;
        GameObject copy;
        copy = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

}
