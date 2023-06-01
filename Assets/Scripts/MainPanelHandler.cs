using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainPanelHandler : MonoBehaviour
{
    public GameObject mainPanel;
    public GameObject pauseMenu1;
    public GameObject car;
    public GameObject parkingPlace1;
    public GameObject parkingPlace2;
    public GameObject parkingPlace3;
    public GameObject parkingPlace4;
    public GameObject parkingPlace5;
    public GameObject parkingPlace6;
    public GameObject parkingPlace7;
    public GameObject parkingPlace8;
    public GameObject parkingPlace9;
    public GameObject parkingPlace10;
    public GameObject parkingPlace11;
    public GameObject parkingPlace12;
    public GameObject parkingPlace13;
    public GameObject parkingPlace14;
    public GameObject parkingPlace15;
    public GameObject parkingPlace16;
    public GameObject parkingPlace17;
    public GameObject parkingPlace18;
    public GameObject parkingPlace19;
    public GameObject parkingPlace20;
    public GameObject parkingPlace21;
    public GameObject parkingPlace22;
    public GameObject parkingPlace23;
    public GameObject parkingPlace24;
    public GameObject parkingPlace25;
    public GameObject parkingPlace26;
    public GameObject parkingPlace27;
    public GameObject parkingPlace28;
    public GameObject parkingPlace29;
    public GameObject parkingPlace30;
    public GameObject parkingPlace31;
    public GameObject parkingPlace32;
    public GameObject parkingPlace33;
    public GameObject parkingPlace34;
    // Start is called before the first frame update
    void Start()
    {
        mainPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        mainPanel.SetActive(false);
        pauseMenu1.SetActive(true);
    }

    public void CheckParking()
    {
        var parkingPlaces = new List<GameObject>() { parkingPlace1, parkingPlace2, parkingPlace3, parkingPlace4, parkingPlace5, parkingPlace6,  parkingPlace7, parkingPlace8, parkingPlace9, parkingPlace10, parkingPlace11, parkingPlace12,  parkingPlace13, parkingPlace14, parkingPlace15, parkingPlace16, parkingPlace17, parkingPlace18,  parkingPlace19, parkingPlace20, parkingPlace21, parkingPlace22, parkingPlace23, parkingPlace24,  parkingPlace25, parkingPlace26, parkingPlace27, parkingPlace28, parkingPlace29, parkingPlace30,  parkingPlace31, parkingPlace32, parkingPlace33, parkingPlace34};
        var minLen = 1e9;
        foreach(var parkingPlace in parkingPlaces)
        {
            if (parkingPlace.active)
            {
                var parkingPlacePosition = parkingPlace.transform.position;
                var CarPosition = car.transform.position;
                float distance = Vector3.Distance(parkingPlace.transform.position, car.transform.position);
                minLen = Math.Min(distance, minLen);

            }
        }
        Debug.Log(minLen.ToString());
    }


}
