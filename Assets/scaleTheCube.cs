using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scaleTheCube : MonoBehaviour
{
    public PlaceOnPlane placeOnPlane;
    public Camera ARcamera;
    public Text scaleText;
    public Text rotationText;
    public Text fovText;
    public GameObject sliders;
    public void scaleCube(Slider slider)
    {
        float value = slider.value;
        placeOnPlane.spawnedObject.transform.localScale = new Vector3(value, value, value);
        scaleText.text = "SCALE: " + value;
    }
    public void rotateCube(Slider slider)
    {
        float value = slider.value;
        placeOnPlane.spawnedObject.transform.rotation = Quaternion.AngleAxis(value, Vector3.up);
        rotationText.text = "Rotate: " + value;
    }

    public void changeFOV(Slider slider)
    {
        float value = slider.value;
        ARcamera.fieldOfView = value;
        fovText.text = "FOV: " + value;
    }

    public void toggleSliders()
    {
        sliders.SetActive(!sliders.activeSelf);
    }
}
