using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipespawnscript : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 1;
    private float timer = 0;

    public float heightOffset = 1;
    private float lowestPoint;
    private float highestPoint;

     
    // Start is called before the first frame update
    void Start()
    {
        lowestPoint = -heightOffset;
        highestPoint = heightOffset;
        PawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        } else {
            timer = 0;
            PawnPipe();
        }
    }

    void PawnPipe() {
        Vector3 spawnPoint = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z);
        Instantiate(pipe, spawnPoint, transform.rotation);
    }
}
