using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public static int score;
    public static float rotationSpeed;
    public static float pinSpeed;

    public Slider rotateSlider;
    public Slider pinSlider;
    public Text rotationText;
    public Text pinText;

    public void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void Update()
    {
        score = Score.pinCount;
    }

    public void setRotateSpeed()
    {
        rotationSpeed = rotateSlider.value;
    }

    public void setPinSpeed()
    {
        pinSpeed = pinSlider.value;
    }

    public void setPinText()
    {
        pinText.text = "Pin Speed: " + pinSlider.value.ToString();
    }

    public void setRotationText()
    {
        rotationText.text = "Rotator Speed: " + rotateSlider.value.ToString();
    }
}
