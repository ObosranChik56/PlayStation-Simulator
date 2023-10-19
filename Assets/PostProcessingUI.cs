using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class PostProcessingUI : MonoBehaviour
{
    public PostProcessVolume postProcessVolume;
    private MotionBlur motionBlur;
    private Vignette vignette;
    private Bloom bloom;

    public Slider motionBlurSlider;
    public Slider vignetteIntensitySlider;
    public Slider bloomIntensitySlider;

    private void Start()
    {
        postProcessVolume = GetComponent<PostProcessVolume>();

        // Отримуємо ефекти з профілю пост-обробки
        postProcessVolume.profile.TryGetSettings(out motionBlur);
        postProcessVolume.profile.TryGetSettings(out vignette);
        postProcessVolume.profile.TryGetSettings(out bloom);
    }

    private void Update()
    {
        SetMotionBlurParameters(motionBlurSlider.value);
        SetVignetteIntensity(vignetteIntensitySlider.value);
        SetBloomIntensity(bloomIntensitySlider.value);
    }

    public void SetMotionBlurParameters(float sliderValue)
    {
        // Перевіряємо, чи motionBlur був успішно отриманий з профілю пост-обробки
        if (motionBlur != null)
        {
            motionBlur.shutterAngle.value = Mathf.Lerp(0, 360, sliderValue);
            motionBlur.sampleCount.value = Mathf.RoundToInt(sliderValue * 64);
            motionBlur.active = sliderValue > 0;
        }
    }

    public void SetVignetteIntensity(float intensity)
    {
        if (vignette != null)
        {
            vignette.intensity.value = intensity;
            vignette.active = intensity > 0;
        }
    }

    public void SetBloomIntensity(float intensity)
    {
        if (bloom != null)
        {
            bloom.intensity.value = intensity;
            bloom.active = intensity > 0;
        }
    }
}
