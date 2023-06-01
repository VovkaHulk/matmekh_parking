using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public GameObject damageMenu;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Parked car")
        {
            Time.timeScale = 0f;
            damageMenu.SetActive(true);
        }

    }
}
