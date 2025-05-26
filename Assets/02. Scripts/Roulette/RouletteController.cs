using UnityEngine;
using UnityEngine.Rendering;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed = 5f;

    public bool isStop;

    private void Start()
    {
        rotSpeed = 0f;
    }


    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed); // Z축 기준으로 회전하는 기능

        //마우스 왼쪽 버튼을 눌럿을 때 회전하는 기능
        if (Input.GetMouseButtonDown(0)) //'0'은 마우스 왼쪽버튼
        {
            rotSpeed = 5f;
        }


        //transform.Rotate(0f, 0f, rotSpeed);

        //Vector3.forward = new Vector3(0f, 0f, 1f)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if (isStop == true)
        {
            rotSpeed *= 0.98f;
          
        }
        if (rotSpeed < 0.01f)
        {
            rotSpeed = 0f;
            isStop = false;
        }

    }
}
