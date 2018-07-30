using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	private static GameManager Instance { get; set; }
	private int _jhanda = 0, _burja =0, _itta = 0, _paan = 0, _hukum = 0, _chiddi = 0;
	private bool _facecounted = false;
	public static GameManager GetInstance()
	{
		if (Instance == null)
		{
			return FindObjectOfType<GameManager>();
		}

		return Instance;
	}
	public DiceScript[] Dice;
	
	
	void Start ()
	{
		Instance = this;
		ResetDiceValues();
	}

	private void Update()
	{
		if (!_facecounted)
		{
			if (Dice[0].DiceValue <6 && Dice[1].DiceValue <6 && Dice[2].DiceValue <6 && Dice[3].DiceValue <6&& Dice[4].DiceValue<6 &&
			    Dice[5].DiceValue < 6)
			{
				FaceCount();
			}
		}
	
	}

	public void ResetDiceValues()
	{
		for (int i = 0; i < 6; i++)
		{
			Dice[i].DiceValue = 6;
			_facecounted = false;
			_jhanda = _burja = _itta = _paan =  _hukum =  _chiddi = 0;
		}
	}
	
	 void FaceCount()
	{
		for (int i = 0; i < 6; i++)
		{
			switch (Dice[i].DiceValue)
			{
				case 0:
					_jhanda++;
					//	_jhanda.Add(Dice[i].DiceValue);
					break;
				case 1:
					_burja++;
					//	_burja.Add(Dice[i].DiceValue);
					break;
				case 2:
					_itta++;
					//	_itta.Add(Dice[i].DiceValue);
					break;
				case 3:
					_hukum++;
					//	_hukum.Add(Dice[i].DiceValue);
					break;
				case 4 :
					_paan++;
					//	_paan.Add(Dice[i].DiceValue);
					break;
				case 5:
					_chiddi++;
					//	_chiddi.Add(Dice[i].DiceValue);
					break;
			}
		}

		_facecounted = true;
		Debug.Log("Burja" + _burja);
		Debug.Log("Jhanda" + _jhanda);
		Debug.Log("Itta" + _itta);
		Debug.Log("Hukum" + _hukum);
		Debug.Log("Paan" + _paan);
		Debug.Log("Chiddi" + _chiddi);

	}


}
