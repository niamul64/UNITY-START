using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreForcar : MonoBehaviour
{
    public Transform car;
    public double zpos;
    public double distance;
    public Text score;
    public Text scoreT;
    public double times;
    // Start is called before the first frame update
    void Start()
    {
        zpos = -18.76;
        times = 0.0;
    }

    // Update is called once per frame
    void Update()
    {
        times = times + Time.deltaTime;
        distance = car.position.z - zpos;
        //score.text = distance.ToString("score: 0");
        scoreT.text = times.ToString("score: 0");
        if (distance > 40)
        {
            score.text = "game over";
        }
    }
}
