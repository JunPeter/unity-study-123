using UnityEngine;

public class CatFollow : MonoBehaviour
{
    public Transform cat;

    private void Update()
    {
        transform.position = cat.transform.position;
    }
}
