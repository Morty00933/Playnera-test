using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float scrollSpeed = 5f; // Скорость прокрутки
    public Vector2 scrollLimits = new Vector2(-10f, 10f); // Ограничения по оси X

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Ввод с клавиш (стрелки или A/D)
        Vector3 newPosition = transform.position + Vector3.right * horizontalInput * scrollSpeed * Time.deltaTime;

        // Ограничиваем позицию камеры
        newPosition.x = Mathf.Clamp(newPosition.x, scrollLimits.x, scrollLimits.y);
        transform.position = newPosition;
    }
}