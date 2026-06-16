using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AmmoCounter : MonoBehaviour
{
    public TMP_Text AmmoValueText;
    private MyPlayerShooting _myplayershooting;

    void Start()
    {
        _myplayershooting = GameObject.FindGameObjectWithTag("Player").GetComponent<MyPlayerShooting>();
    }

    void UpdateAmmoValueText()
    {
        if (AmmoValueText != null)
        AmmoValueText.text = $"{_myplayershooting.ammo:0}";
    }
}
