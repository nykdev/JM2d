using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    private static UiController Instance { get; set; }

    public static UiController GetInstance()
    {
        if (Instance == null)
        {
            return FindObjectOfType<UiController>();
        }

        return Instance;
    }
    [HideInInspector] public bool Shuffle;

    
    
   
    private void Start()
    {
        Instance = this;
    }


    public void ShuffleDice()
    {
        Shuffle = true;
        GameManager.GetInstance().ResetDiceValues();
    }
}
