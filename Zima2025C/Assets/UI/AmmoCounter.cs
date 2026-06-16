using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoCounter : MonoBehaviour
{
    public TMP_Text AmmoValueText;
    public MyPlayerShooting playerShooting;

    void Start()
    {

    }

    void Update()
    {
        if (playerShooting != null && AmmoValueText != null)
        {
            AmmoValueText.text = "Ammo: " + playerShooting.currentAmmo.ToString();
        }
    }
}