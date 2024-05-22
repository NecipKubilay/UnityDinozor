using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class HedefRandom : MonoBehaviour
{
    public static HedefRandom Instance { get; private set; }

    public TextMeshProUGUI hedefSayi;

    public int randomHedef;
    


    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }



    void Start()
    {
        RandomStart();
    }
    

    public void RandomStart()
    {
        randomHedef = Random.Range(20, 40);
        hedefSayi.text = randomHedef.ToString();
    }
}
