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
            var positionOfParkingPlace = gameObject.transform.position;
            positionOfParkingPlace.y += 0;
            Instantiate(car, positionOfParkingPlace, gameObject.transform.rotation);
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
