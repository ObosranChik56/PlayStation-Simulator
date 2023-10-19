using UnityEngine;
using UnityEngine.UI;

public class PCbuttons : MonoBehaviour
{
    public Button button; // Посилання на кнопку, яку ви хочете активувати
    private Color originalButtonColor; // Оригінальний колір кнопки

    private void Start()
    {
        // Зберігаємо оригінальний колір кнопки
        originalButtonColor = button.image.color;

        // Деактивуємо кнопку на початку гри (зробимо її прозорою)
        button.interactable = false;
        Color transparentColor = originalButtonColor;
        transparentColor.a = 0f;
        button.image.color = transparentColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Перевіряємо, чи зіткнувся гравець з колайдером
        if (other.CompareTag("Player"))
        {
            // Активуємо кнопку, якщо гравець входить в колайдер
            button.interactable = true;
            button.image.color = originalButtonColor; // Відновлюємо оригінальний колір
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Перевіряємо, чи гравець вийшов з колайдера
        if (other.CompareTag("Player"))
        {
            // Деактивуємо кнопку (зробимо її прозорою)
            button.interactable = false;
            Color transparentColor = originalButtonColor;
            transparentColor.a = 0f;
            button.image.color = transparentColor;
        }
    }
}
