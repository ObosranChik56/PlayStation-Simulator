using UnityEngine;

public class coliderSeyf : MonoBehaviour
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
