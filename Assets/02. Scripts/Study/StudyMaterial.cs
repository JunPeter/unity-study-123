using UnityEngine;

public class StudyMaterial : MonoBehaviour
{
    public Material mat;

    public string hexcode;
    
    void Start()
    {
        // this.GetComponent<MeshRenderer>().material = mat; // MeshRenderer�� �����ؼ� �ٲٴ� ���

        // this.GetComponent<MeshRenderer>().sharedMaterial = mat; // MeshRenderer�� �����ؼ� �ٲٴ� ���

        //this.GetComponent<MeshRenderer>().material.color = Color.green; 

        //this.GetComponent<MeshRenderer>().materials

        //this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;

        //this.GetComponent<MeshRenderer>().material.color 
        //    = new Color(130f/255f, 20f/255f, 70f/255f, 1);

        Material mat = this.GetComponent<MeshRenderer>().material;
        Color outputColor;

        if(ColorUtility.TryParseHtmlString(hexcode, out outputColor))
        {
            mat.color = outputColor;
        }
    
    }

    
}