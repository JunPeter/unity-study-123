using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab;
    public Transform firePos;

    public float timer;
    public float cooldownTime;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() // ���𰡸� �����ϴ� ���
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update() // ����⸦ �ٶ󺸴� ���

    {
        turretHead.LookAt(targetTf);

        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }


    }
}
