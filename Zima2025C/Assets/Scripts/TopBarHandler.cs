using UnityEngine;
using UnityEngine.UI;

public class TopBarHandler : MonoBehaviour
{
    public Gradient HPColorGradient;
    public Slider HPSlider;
    public Image FillImage;
    private PlayerController _playerController;
 
    void Start()
    {
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        _playerController.OnHPChanged += UpdateHPBar;
        UpdateHPBar();
    }

    public void UpdateHPBar()
    {
        HPSlider.value = _playerController.hp / 100.0f;
        FillImage.color = HPColorGradient.Evaluate(_playerController.hp / 100.0f);
    }
}
