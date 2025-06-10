using UnityEngine;

public class Transform_LoopMap : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float returnPosX = 15;
    public float randomPosY;

    public Vector3 returnPos;

    private void Start()
    {
        randomPosY = Random.Range(-8f, -5.2f);

        transform.position = new Vector3(transform.position.x, transform.position.y, 0f);
    }
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= -returnPosX)
        {
            randomPosY = Random.Range(-8f, -5.2f);

            transform.position = new Vector3(returnPosX, randomPosY, 0);
        }
    }
}