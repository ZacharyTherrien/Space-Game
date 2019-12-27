﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPowerUp : MonoBehaviour
{
    public GameObject player;
    public GameObject PowerUpBullet;
    public float weaponDuration;
    public float weaponShootDelay;
    private void OnTriggerEnter(Collider other) //checks for sphere collisions
    {
        if (other.gameObject == player) //checks for player collision
        {
            //Set the current weapon to the desired weapon
            other.gameObject.GetComponentInChildren<WeaponBehavior>().ChangeBullet(PowerUpBullet, weaponShootDelay, weaponDuration);
            Destroy(this.gameObject);
        }
    }
}