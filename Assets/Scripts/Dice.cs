﻿using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour {

    private Sprite[] _diceSides;
    private SpriteRenderer _rend;
//    private int whosTurn = 1;
    private bool _coroutineAllowed = true;
  //  private int randroll;

	// Use this for initialization
	private void Start () {
        _rend = GetComponent<SpriteRenderer>();
        _diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        _rend.sprite = _diceSides[5];
	    
	}

    private void Update()
    {
        if (UiController.GetInstance().Shuffle && _coroutineAllowed)
        {
                StartCoroutine("RollTheDice");
        }
    }

        

    private IEnumerator RollTheDice()
    {
         
        _coroutineAllowed = false;
        int rand = Random.Range(20, 60);
        for (int i = 0; i <= rand; i++)
        {
            var randomDiceSide = Random.Range(0, 6);
            _rend.sprite = _diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
            UiController.GetInstance().Shuffle = false;

        }
/*

        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        } else if (whosTurn == -1)
        {
            GameControl.MovePlayer(2);
        }
        whosTurn *= -1;*/
        _coroutineAllowed = true;
    }
}
