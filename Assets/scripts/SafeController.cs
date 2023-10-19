using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    public InputField inputField;
    public GameObject moneyPanel; // ��������� �� ��'��� MoneyPanel

    private void Start()
    {
        // ������ ������� �� ���� ���������� ������ Enter
        inputField.onEndEdit.AddListener(OnInputFieldEndEdit);
    }

    private void OnInputFieldEndEdit(string inputText)
    {
        // ����������, �� �������� ����� ������� "01091939"
        if (inputText == "01091939")
        {
            // ���� ���, �������� ��'��� MoneyPanel
            moneyPanel.SetActive(true);
        }
        else
        {
            
            moneyPanel.SetActive(false);
        }
    }
}
