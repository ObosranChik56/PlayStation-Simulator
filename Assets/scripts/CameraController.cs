using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // ��'���, �� ����� ���� ���������� ������� ������
    public float rotationSpeed = 5f; // �������� �������� ������

    private bool isColliding = false; // ����, �� ����� �� �������� � ����������

    private void Update()
    {
        if (isColliding)
        {
            // �������� �������� �� ��'����
            Vector3 directionToTarget = target.position - transform.position;

            // ����������� ����� ������� ������ � ������� ���������
            Quaternion newRotation = Quaternion.LookRotation(directionToTarget);
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // ��������, �� ������� �������� � ����������
        {
            isColliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // ��������, �� ������� ������ � ���������
        {
            isColliding = false;
        }
    }
}
