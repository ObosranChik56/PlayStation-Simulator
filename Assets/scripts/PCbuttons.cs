using UnityEngine;
using UnityEngine.UI;

public class PCbuttons : MonoBehaviour
{
    public Button button; // ��������� �� ������, ��� �� ������ ����������
    private Color originalButtonColor; // ����������� ���� ������

    private void Start()
    {
        // �������� ����������� ���� ������
        originalButtonColor = button.image.color;

        // ���������� ������ �� ������� ��� (������� �� ��������)
        button.interactable = false;
        Color transparentColor = originalButtonColor;
        transparentColor.a = 0f;
        button.image.color = transparentColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        // ����������, �� �������� ������� � ����������
        if (other.CompareTag("Player"))
        {
            // �������� ������, ���� ������� ������� � ��������
            button.interactable = true;
            button.image.color = originalButtonColor; // ³��������� ����������� ����
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // ����������, �� ������� ������ � ���������
        if (other.CompareTag("Player"))
        {
            // ���������� ������ (������� �� ��������)
            button.interactable = false;
            Color transparentColor = originalButtonColor;
            transparentColor.a = 0f;
            button.image.color = transparentColor;
        }
    }
}
