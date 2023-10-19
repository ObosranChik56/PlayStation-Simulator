using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // Об'єкт, до якого буде відбуватися поворот камери
    public float rotationSpeed = 5f; // Швидкість повороту камери

    private bool isColliding = false; // Флаг, що вказує на зіткнення з колайдером

    private void Update()
    {
        if (isColliding)
        {
            // Отримуємо напрямок до об'єкта
            Vector3 directionToTarget = target.position - transform.position;

            // Розраховуємо новий поворот камери з плавним переходом
            Quaternion newRotation = Quaternion.LookRotation(directionToTarget);
            transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Перевірка, чи гравець зіткнувся з колайдером
        {
            isColliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Перевірка, чи гравець вийшов з колайдера
        {
            isColliding = false;
        }
    }
}
