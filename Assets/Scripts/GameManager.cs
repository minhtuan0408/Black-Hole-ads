using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Image timerCircle;   
    public TMP_Text timerText;  

    public float totalTime = 30f;   
    private float currentTime;

    private bool timeUp = false;
    private int count = 0;
    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

            timerCircle.fillAmount = currentTime / totalTime;
            timerText.text = Mathf.CeilToInt(currentTime).ToString();
            timeUp = true;
            
        }
        else if (timeUp && count <=1)
        {
            count += 1;
            Debug.Log("Hết giờ chơi!");
            currentTime = 0;
            timerText.text = "0";
            timerCircle.fillAmount = 0;
            EndGame();
        }

    }

    private void EndGame()
    {
        Debug.Log("Hết giờ chơi!");
        Time.timeScale = 0;

    }
}
