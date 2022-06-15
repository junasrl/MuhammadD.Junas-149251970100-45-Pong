using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public Text scoreKiri;
    public Text scoreKanan;

    public ScoreManager manager;

    private void Update()
    {
        scoreKiri.text = manager.skorKiri.ToString();
        scoreKanan.text = manager.skorKanan.ToString(); 
    }

}
