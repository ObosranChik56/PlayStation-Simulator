using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    private void Update()
    {
        // Перевіряємо, чи користувач натиснув на екран (тачскрін)
        if (Input.touchCount > 0)
        {
            // Отримуємо перший тач (натискання) зі списку натискань
            Touch touch = Input.GetTouch(0);

            // Перевіряємо, чи натискання було виконано на об'єкті
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Перевіряємо, чи об'єкт має колайдер
                if (hit.collider != null)
                {
                    // Виводимо повідомлення в чат
                    Debug.Log("Натиснено");
                }
            }
        }
    }
}
