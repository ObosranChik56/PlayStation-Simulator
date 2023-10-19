using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PackageCol: MonoBehaviour
{
    public GameObject cameraTouchpad; // ��������� �� ��'��� ������� ������
    public GameObject SFX;
    public GameObject Package;
    public GameObject ColI;
    public GameObject poco;
    private bool isDisabled = false;
    public Transform target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // �������� ������
            cameraTouchpad.SetActive(false);
            SFX.SetActive(false);
            Package.SetActive(true);
            poco.SetActive(true);

            isDisabled = true;

            // ��������� ����� ��� ��������� ������� ����� 3 �������
            Invoke("EnableTouchpad", 2f);




            // �������� �������� �� ��'����
            Vector3 directionToTarget = target.position - transform.position;

            // ����������� ����� ������� ������
            Quaternion newRotation = Quaternion.LookRotation(directionToTarget);

            // ����������� ����� ������� �� ������
            transform.rotation = newRotation;
        }
    }

    private void EnableTouchpad()
    {
        if (isDisabled)
        {
            // �������� ������
            cameraTouchpad.SetActive(true);
            isDisabled = false;
            ColI.SetActive(true);
        }
    }
}
