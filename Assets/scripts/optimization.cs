using UnityEngine;

public class optimization : MonoBehaviour
{
    public GameObject objectToDeactivate; // ���������� GameObject, ���� �� ������ ��������, �� ����������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ��������, �� ������� ������ � ��������
        {
            objectToDeactivate.SetActive(false); // �������� ��'���
        }
    }
}
