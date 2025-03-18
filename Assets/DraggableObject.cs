using UnityEngine;

public class DraggableObject : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool isDragging = false;
    private Vector3 offset;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<SpriteRenderer>().sortingLayerName = "Objects";
    }

    void OnMouseDown()
    {
        isDragging = true;
        rb.isKinematic = true; // ��������� ������ �� ����� ��������������
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseUp()
    {
        isDragging = false;
        rb.isKinematic = false; // �������� ������ (����������) ��� ����������
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x + offset.x, mousePos.y + offset.y, transform.position.z);
        }
    }
}