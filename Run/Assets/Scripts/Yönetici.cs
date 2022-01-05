using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yönetici : MonoBehaviour
{
    public Text skortext;

    public static float skorsayisi;
    void Update()
    {
        skortext.text=skorsayisi.ToString();
        
    }
}
