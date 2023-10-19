using UnityEngine;

public class optiimization : MonoBehaviour
{
    public GameObject objectToDeactivate; // Перетягніть GameObject, який ви хочете вимкнути, до інспектора

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Перевірка, що гравець увійшов у колайдер
        {
            objectToDeactivate.SetActive(true); // Вимкнути об'єкт
        }
    }
}
