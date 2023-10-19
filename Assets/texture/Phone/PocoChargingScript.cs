using UnityEngine;
using UnityEngine.UI;

public class BatteryCharging : MonoBehaviour
{
    public Text percentageText;
    public Text timeText;
    public Image fillImage;
    public GameObject Power;
    public GameObject cable;
    public GameObject Def;
    public GameObject Palnt;
    public GameObject text;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject Balance;
    public GameObject ekpsDostup;    

    public float chargePercentage = 0f;
    public bool isCharging = false;
    public float countdownTimer = 10f;
    public bool isCountingDown = false;
    public Color startColor = Color.white;
    public Color targetColor = Color.red;
    public float colorChangeDuration = 1.0f;
    public float colorChangeStartTime;

    void Update()
    {
        if (isCharging)
        {
            chargePercentage += Time.deltaTime * 3.33f;
            chargePercentage = Mathf.Clamp(chargePercentage, 0f, 100f);

            percentageText.text = Mathf.Round(chargePercentage) + "%";
            fillImage.fillAmount = chargePercentage / 100f;

            if (chargePercentage >= 100f)
            {
                Debug.Log("Телефон на 100%!");
                StopCharging();
            }
        }
        else
        {
            fillImage.fillAmount = 0;
        }

        if (isCountingDown)
        {
            countdownTimer -= Time.deltaTime;
            timeText.text = Mathf.Round(countdownTimer) + " сек.";

            if (countdownTimer <= 0f)
            {
                Debug.Log("Час вийшов!");
                countdownTimer = 10f;
                isCountingDown = false;
            }
        }

        // Плавна зміна кольору
        if (Time.time < colorChangeStartTime + colorChangeDuration)
        {
            float t = (Time.time - colorChangeStartTime) / colorChangeDuration;
            fillImage.color = Color.Lerp(startColor, targetColor, t);
        }
    }


    public void ButtonClicked()
    {
        if (isCharging)
        {
            StopCharging();
        }
        else if (chargePercentage < 100f)
        {
            StartCharging();
        }
        else
        {
            Debug.Log("Телефон на 100%!");
            Power.gameObject.SetActive(true);
            text.gameObject.SetActive(false);
            text1.gameObject.SetActive(true);
        }
    }

    public void StopCharging()
    {
        isCharging = false;
        isCountingDown = false;
        countdownTimer = 10f;
        startColor = fillImage.color;
        targetColor = Color.white;
        colorChangeStartTime = Time.time;
        cable.gameObject.SetActive(false);
        Def.gameObject.SetActive(true);
        Palnt.gameObject.SetActive(false);

    }

    public void StartCharging()
    {
        isCharging = true;
        isCountingDown = true;
        countdownTimer = 10f;
        startColor = fillImage.color;
        targetColor = Color.red;
        colorChangeStartTime = Time.time;
        cable.gameObject.SetActive(true);
        Def.gameObject.SetActive(false);
        Palnt.gameObject.SetActive(true);
    }
    public void Start()
    {
        StopCharging();
    }

    public void Monobank() {
    text1.gameObject.SetActive (false);
        text2.gameObject.SetActive (true); 
    }
}
