using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MenuScript : MonoBehaviour
{
    public TMP_Text hardness;

    public void StartLevel()
    {
        PlayerPrefs.SetInt("Difficulty", int.Parse(hardness.text));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlusHard()
    {
        hardness.text = math.min(int.Parse(hardness.text) + 1, 9).ToString();
    }

    public void MinusHard()
    {
        hardness.text = math.max(int.Parse(hardness.text) - 1, 1).ToString();
    }
}
