using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0, 10) <= PlayerPrefs.GetInt("Difficulty"))
        {
            Instantiate(car, transform.position, Quaternion.Euler(0, 0, -45));
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
