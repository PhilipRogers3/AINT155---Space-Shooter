using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEbgine.UI;

public class WeaponButton : MonoBehaviour
{
    public PlayerShooting playerShooting;
    public int weaponNumber;

    void Start()
    {
        source = GetComponent<AudioSource>();
        SetButton();
    }

    void SetButton()
    {
        string costString = playerShooting.weapons[weaponNumber].cost.ToString();
        name.Text = playerShooting.weapons[weaponNumber].name;
        cost.text = "£" + playerShooting.weapons[weaponNumber].cost;
        description.text = playerShooting.weapons[weaponNumber].description;
    }

    public void OnClick()
    {
        if (ScoreManager.score >= playerShooting.weapons [weaponNumber].cost)
        {
            ScoreManager.score -= playerShooting.weapons[weaponNumber].cost;
            playerShooting.currentWeapon = weaponNumber;
        } else
        {
            source.Play();
        }
    }
	
}
