using UnityEngine;
using UnityEngine.UI;

public class TopBarHandler : MonoBehaviour
{

    private PlayerController _playerController;
    public Slider HPSlider;
    public Gradient HPColorGradient;
    public Image FillImage;
    void Start()
    {
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        _playerController.OnHPChanged += UpdateHPSlider;
        UpdateHPSlider();
    }


    void UpdateHPSlider()
    {
        HPSlider.value = _playerController.hp / 100;
        FillImage.color = HPColorGradient.Evaluate(_playerController.hp / 100);
    }
}
