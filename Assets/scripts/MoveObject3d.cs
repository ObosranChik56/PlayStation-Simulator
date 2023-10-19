using UnityEngine;

public class MoveObject3D : MonoBehaviour
{
    private Rigidbody rb;
    private bool isDragging = false;
    private Vector3 touchOffset;
    private Vector3 velocity = Vector3.zero;
    public float smoothTime = 0.3f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Ray ray = Camera.main.ScreenPointToRay(touch.position);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
                    {
                        isDragging = true;
                        touchOffset = transform.position - hit.point;
                    }
                    break;

                case TouchPhase.Moved:
                    if (isDragging)
                    {
                        Ray newRay = Camera.main.ScreenPointToRay(touch.position);
                        Vector3 newPosition = newRay.GetPoint(touchOffset.magnitude);
                        rb.MovePosition(Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime));
                    }
                    break;

                case TouchPhase.Ended:
                    isDragging = false;
                    break;
            }
        }
    }
}
