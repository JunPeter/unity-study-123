using UnityEngine;

public class ItemEvent : MonoBehaviour
{
    public enum ColliderType { pipe, cherries, Both }
    public ColliderType colliderType;

    public GameObject pipe;
    public GameObject cherries;
    public GameObject particle;

    public float moveSpeed = 3f;
    public float returnPosX = 15f;
    public float randomPosY;

    public Vector3 returnPos;

    private void Start()
    {
        SetRandomSetting(transform.position.x);
    }
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -returnPosX)
            SetRandomSetting(returnPosX);

    }

    private void SetRandomSetting(float posX)
    {
        randomPosY = Random.Range(-8f, -5.1f);

        transform.position = new Vector3(transform.position.x, transform.position.y, 0);

        Random.Range(0, 3);

        switch (colliderType)
        {
            case ColliderType.pipe:
                pipe.SetActive(true);
                break;
            case ColliderType.cherries:
                cherries.SetActive(true);
                break;
            case ColliderType.Both:
                pipe.SetActive(true);
                cherries.SetActive(true);
                break;
        }
    }
}
