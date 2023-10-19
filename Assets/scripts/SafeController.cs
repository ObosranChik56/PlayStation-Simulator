using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    public InputField inputField;
    public GameObject moneyPanel; // Посилання на об'єкт MoneyPanel

    private void Start()
    {
        // Додаємо слухача на подію натискання клавіші Enter
        inputField.onEndEdit.AddListener(OnInputFieldEndEdit);
    }

    private void OnInputFieldEndEdit(string inputText)
    {
        // Перевіряємо, чи введений текст дорівнює "01091939"
        if (inputText == "01091939")
        {
            // Якщо так, увімкнути об'єкт MoneyPanel
            moneyPanel.SetActive(true);
        }
        else
        {
            
            moneyPanel.SetActive(false);
        }
    }
}
