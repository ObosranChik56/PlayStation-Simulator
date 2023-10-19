using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator doorAnimator;
    private bool isOpen = false;

    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
                {
                    ToggleDoor();
                }
            }
        }
        else if (Input.GetMouseButtonDown(0)) // Перевіряємо натискання лівої кнопки миші.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                ToggleDoor();
            }
        }
    }

    private void ToggleDoor()
    {
        if (isOpen)
        {
            doorAnimator.Play("CloseDoor"); // Анімація закривання дверей.
            isOpen = false;
        }
        else
        {
            doorAnimator.Play("OpenDoor"); // Анімація відкривання дверей.
            isOpen = true;
        }
    }
}
