using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OldmanAge : MonoBehaviour
{
    public int oldmanAge = 80;
    public GameObject ageObject = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text age = ageObject.GetComponent<Text>();
        age.text = "は" + oldmanAge + "歳で生を全うしたのだ..."; 
    }
}
