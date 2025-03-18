using UnityEngine;

public class SortingOrderUpdater : MonoBehaviour
{
    void LateUpdate()
    {
        GetComponent<SpriteRenderer>().sortingOrder = (int)(-transform.position.y * 100);
    }
}