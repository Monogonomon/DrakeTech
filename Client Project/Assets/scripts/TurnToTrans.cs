using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToTrans : MonoBehaviour {

    public float yRotation = 5.0F;

    public GameObject imageSphere;
    private float angY;

    // Use this for initialization
    void Start () {
        yRotation += Input.GetAxis("Horizontal");
        transform.eulerAngles = new Vector3(10, yRotation, 0);
    }
	
	// Update is called once per frame
	void Update () {
        Debug.Log(transform.eulerAngles.y);

        angY = transform.eulerAngles.y;

        ChangeImage();
    }

    private void ChangeImage()
    {
        if (angY < 90.0)
        {
            imageSphere.GetComponent<ChangeImage>().ToImageOne();
        }
        else if ((angY < 180.0) & (angY > 90.0))
        {
            imageSphere.GetComponent<ChangeImage>().ToImageTwo();
        }
        else if ((angY < 270.0) & (angY > 180.0))
        {
            imageSphere.GetComponent<ChangeImage>().ToImageThree();
        }
        else if (angY > 270.0)
        {
            imageSphere.GetComponent<ChangeImage>().ToImageFour();
        }
    }
}
