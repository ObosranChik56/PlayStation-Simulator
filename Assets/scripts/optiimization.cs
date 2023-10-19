using UnityEngine;

public class optiimization : MonoBehaviour
{
    public GameObject objectToDeactivate; // ���������� GameObject, ���� �� ������ ��������, �� ����������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ��������, �� ������� ������ � ��������
        {
            objectToDeactivate.SetActive(true); // �������� ��'���
        }
    }
}
