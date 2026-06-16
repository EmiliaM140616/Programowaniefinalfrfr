using System.Reflection;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public MyPlayerShooting playerShooting;
    public GameObject pickupEffect;

    void Start () 
    {
        playerShooting = GameObject.FindWithTag("Player")
            .GetComponent<MyPlayerShooting>();
    }   

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
            playerShooting.currentAmmo += 50;
            Destroy(gameObject);
        }
    }
}