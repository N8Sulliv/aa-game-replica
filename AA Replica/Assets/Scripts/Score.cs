using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int pinCount = 0;
    public Text score;

    private void Start()
    {
        pinCount = 0;
    }

    private void Update()
    {
        score.text = pinCount.ToString();
    }
}
