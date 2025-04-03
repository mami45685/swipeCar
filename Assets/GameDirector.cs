using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Unity.VisualScripting;

public class GameDirector : MonoBehaviour
{
    public Transform car;
    public Transform flag;
    public TextMeshProUGUI distance;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.position.x - this.car.position.x-1.71f;
        this.distance.text = "距離:" + length.ToString("F2") + "m";
    }
}
