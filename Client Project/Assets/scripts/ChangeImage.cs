using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour {

    public Material imageOne;
    public Material imageTwo;
    public Material imageThree;
    public Material imageFour;

    //How to
    //this.gameObject.GetComponent<Renderer>().material = matName;

    public void ToImageOne()
    {
        this.gameObject.GetComponent<Renderer>().material = imageOne;
    }

    public void ToImageTwo()
    {
        this.gameObject.GetComponent<Renderer>().material = imageTwo;
    }

    public void ToImageThree()
    {
        this.gameObject.GetComponent<Renderer>().material = imageThree;
    }

    public void ToImageFour()
    {
        this.gameObject.GetComponent<Renderer>().material = imageFour;
    }

}
