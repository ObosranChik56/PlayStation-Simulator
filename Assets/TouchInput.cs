using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    private void Update()
    {
        // ����������, �� ���������� �������� �� ����� (�������)
        if (Input.touchCount > 0)
        {
            // �������� ������ ��� (����������) � ������ ���������
            Touch touch = Input.GetTouch(0);

            // ����������, �� ���������� ���� �������� �� ��'���
            Ray ray = Camera.main.ScreenPointToRay(touch.position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // ����������, �� ��'��� �� ��������
                if (hit.collider != null)
                {
                    // �������� ����������� � ���
                    Debug.Log("���������");
                }
            }
        }
    }
}
