using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingEvent : MonoBehaviour
{
    GameManager manager;
    float finaltime;

    public Text FinalTime;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        finaltime = manager.GetTimerTime();
    }

    // Update is called once per frame
    void Update()
    {
        FinalTime.text = "���� ����!\r\n�� " + finaltime + "�� �ɸ�";
    }
}
