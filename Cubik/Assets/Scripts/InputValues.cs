using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputValues : MonoBehaviour
{
   
    public InputField SpawnRate;
    public InputField Distance;
    public InputField Speed;

    
    public void Start()
    {
        Move.Range = (float.Parse(Distance.text));
        Move.Speed = (float.Parse(Speed.text));
        Spawner.TimeBetweenRespawn = (float.Parse(SpawnRate.text));
    }
}
