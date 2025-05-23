using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        /// Input System (Old - Legacy)
        /// �Է°��� ���� ��ӵ� �ý���
        /// �̵� -> WASD, ȭ��ǥŰ����
        /// ���� -> Space
        /// �ѽ�� -> ���콺 ����


        // �ε巴�� �����ϴ� ��
        //float h = Input.GetAxis("Horizontal");
        //float v = Input.GetAxis("Vertical");

        // �� �������� ��
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        Vector3 normalDir = dir.normalized; // ����ȭ ����(0 ~ 1) 

        Debug.Log($"���� �Է� : {normalDir}");

        transform.position += normalDir * moveSpeed * Time.deltaTime;

        transform.LookAt(transform.position + normalDir);
    }
}