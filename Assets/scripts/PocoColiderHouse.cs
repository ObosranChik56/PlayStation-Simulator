using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PocoColiderHouse : MonoBehaviour
{
    public GameObject PanelPoco;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Poco"))
        {
            Invoke("EnableTouchpad", 2f);
            PanelPoco.SetActive(true);
        }
    }

    
}
