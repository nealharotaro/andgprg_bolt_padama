using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public float startTime;
    [SerializeField] Text timer;
    public Text powerUp;

    // Start is called before the first frame update
    void Start()
    {
        powerUp = GetComponent<Text>();
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timer.text = currentTime.ToString("0");
    }
}
