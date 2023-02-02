using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterFill : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform Panel;
    [SerializeField] private GameObject btn;
    void Start()
    {
        for(int i = 0; i < 30; i++)
        {
            var btn1 = Instantiate(btn, Panel);
            btn1.GetComponentInChildren<Text>().text = i.ToString();
        }
    }
}
