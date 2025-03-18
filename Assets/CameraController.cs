using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float scrollSpeed = 5f; // �������� ���������
    public Vector2 scrollLimits = new Vector2(-10f, 10f); // ����������� �� ��� X

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // ���� � ������ (������� ��� A/D)
        Vector3 newPosition = transform.position + Vector3.right * horizontalInput * scrollSpeed * Time.deltaTime;

        // ������������ ������� ������
        newPosition.x = Mathf.Clamp(newPosition.x, scrollLimits.x, scrollLimits.y);
        transform.position = newPosition;
    }
}