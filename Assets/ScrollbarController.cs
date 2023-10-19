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
        // Ініціалізуємо значення скролл-бару і встановлюємо його максимальне значення на основі контенту.
        scrollbar.value = 0.0f;
        scrollbar.size = 1.0f / (content.childCount - 1);
    }

    private void Update()
    {
        // Оновлюємо цільове значення прокрутки на основі значення скролл-бару.
        targetScrollPosition = scrollbar.value;

        // Плавно міняємо поточне значення прокрутки до цільового значення.
        scrollPosition = Mathf.Lerp(scrollPosition, targetScrollPosition, Time.deltaTime * 5.0f);

        // Застосовуємо прокрутку контенту. Змінюйте цей рядок коду відповідно до вашої логіки прокрутки.
        content.anchoredPosition = new Vector2(content.anchoredPosition.x, Mathf.Lerp(0, -(content.rect.height - content.parent.GetComponent<RectTransform>().rect.height), scrollPosition));
    }
}
