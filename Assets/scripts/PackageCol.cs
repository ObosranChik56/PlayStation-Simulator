using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PackageCol: MonoBehaviour
{
    public GameObject cameraTouchpad; // Посилання на об'єкт тачпаду камери
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
            // Вимкнути тачпад
            cameraTouchpad.SetActive(false);
            SFX.SetActive(false);
            Package.SetActive(true);
            poco.SetActive(true);

            isDisabled = true;

            // Викликати метод для увімкнення тачпаду через 3 секунди
            Invoke("EnableTouchpad", 2f);




            // Отримуємо напрямок до об'єкта
            Vector3 directionToTarget = target.position - transform.position;

            // Розраховуємо новий поворот камери
            Quaternion newRotation = Quaternion.LookRotation(directionToTarget);

            // Застосовуємо новий поворот до камери
            transform.rotation = newRotation;
        }
    }

    private void EnableTouchpad()
    {
        if (isDisabled)
        {
            // Увімкнути тачпад
            cameraTouchpad.SetActive(true);
            isDisabled = false;
            ColI.SetActive(true);
        }
    }
}
