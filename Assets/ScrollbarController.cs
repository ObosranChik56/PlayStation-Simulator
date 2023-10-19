using UnityEngine;
using UnityEngine.UI;

public class ScrollbarController : MonoBehaviour
{
    public Scrollbar scrollbar;
    public RectTransform content;

    private float scrollPosition = 0.0f;
    private float targetScrollPosition = 0.0f;

    private void Start()
    {
        // ���������� �������� ������-���� � ������������ ���� ����������� �������� �� ����� ��������.
        scrollbar.value = 0.0f;
        scrollbar.size = 1.0f / (content.childCount - 1);
    }

    private void Update()
    {
        // ��������� ������� �������� ��������� �� ����� �������� ������-����.
        targetScrollPosition = scrollbar.value;

        // ������ ������ ������� �������� ��������� �� ��������� ��������.
        scrollPosition = Mathf.Lerp(scrollPosition, targetScrollPosition, Time.deltaTime * 5.0f);

        // ����������� ��������� ��������. ������� ��� ����� ���� �������� �� ���� ����� ���������.
        content.anchoredPosition = new Vector2(content.anchoredPosition.x, Mathf.Lerp(0, -(content.rect.height - content.parent.GetComponent<RectTransform>().rect.height), scrollPosition));
    }
}
