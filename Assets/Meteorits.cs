using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorits : MonoBehaviour
{
    public GameObject[] objects;
    private GameObject inst_obj;
    public Vector2 direction;


    void Start()
    {
        StartCoroutine("SpawnMeteors");
    }

    void FixedUpdate()
    {
        inst_obj.transform.Translate(new Vector2(-0.05f, 0f));
    }
}