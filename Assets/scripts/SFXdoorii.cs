using UnityEngine;
using UnityEngine.SceneManagement;

public class SFXdoorii : MonoBehaviour
{
    public GameObject SFX;
    public GameObject Col;
    public GameObject SFXDoorCol;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            SFX.SetActive(true);
            Col.SetActive(true);
            SFXDoorCol.SetActive(false);

        }
    }
}
