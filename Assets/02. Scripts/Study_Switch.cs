using UnityEngine;

public class Study_Switch : MonoBehaviour
{
    public enum CalculationType { Plus, Minus, Multiply, Divide }
    public CalculationType calculationType;

    public int input1, input2, result;

    void Start()
    {
        result = Calculation();
        Debug.Log($"��� ��� : {Calculation()}");
    }

    private int Calculation()
    {
        int value = 0;

        switch (calculationType)
        {
            case CalculationType.Plus:
                result = input1 + input2;
                break;
            case CalculationType.Minus:
                result = input1 - input2;
                break;
            case CalculationType.Multiply:
                result = input1 * input2;
                break;
            case CalculationType.Divide:
                result = input1 / input2;
                break;

        }

        return result;
    }
}
