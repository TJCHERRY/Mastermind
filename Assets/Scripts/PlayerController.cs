using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
//	public GameObject yellowPrefab;
//public GameObject bluePrefab;
	//public GameObject purplePrefab;
//	public GameObject redPrefab;
	//public GameObject greenPrefab;
	public List<GameObject> CoinPrefab;
	public List<GameObject> coinSLot;
	public  GameObject[,] m_coinSlot;
	private  Board boardObj;
	[HideInInspector]
	public GameObject CurrentCoin;
	int i = 0;
	// Use this for initialization
	void Start () {
		m_coinSlot =new GameObject[Board._row,Board._column];
		boardObj = gameObject.GetComponent<Board> ();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void YellowButton(){
	
		if (boardObj.rowfull != true) {
			boardObj.currentPos+=1;
			//CurrentCoin = Instantiate (CoinPrefab[0], boardObj.row [boardObj.currentPos].transform.position, Quaternion.identity);
			CurrentCoin = Instantiate (CoinPrefab[0], boardObj.grid [Board.currentRow,boardObj.currentPos].transform.position, Quaternion.identity);
			//coinSLot.Add (CurrentCoin);
			m_coinSlot [Board.currentRow, boardObj.currentPos] = CurrentCoin;
			Debug.Log(Board.currentRow+ ","+boardObj.currentPos);
			Debug.Log(m_coinSlot[Board.currentRow,boardObj.currentPos]);
			//Debug.Log (m_coinSlot.Length);

			//Debug.Log (boardObj.currentPos);
		}
		else {

			boardObj.currentPos += 0;

		}

	
	}

	public void RedButton(){
		if (boardObj.rowfull != true) {
			boardObj.currentPos += 1;
			//CurrentCoin = Instantiate (CoinPrefab[1], boardObj.row [boardObj.currentPos].transform.position, Quaternion.identity);
			CurrentCoin = Instantiate (CoinPrefab [1], boardObj.grid [Board.currentRow, boardObj.currentPos].transform.position, Quaternion.identity);
			//coinSLot.Add (CurrentCoin);
			m_coinSlot [Board.currentRow, boardObj.currentPos] = CurrentCoin;
			Debug.Log (Board.currentRow + "," + boardObj.currentPos);
			//Debug.Log (coinSLot.Count);

			//Debug.Log (boardObj.currentPos);
		} 
		else {
		
			boardObj.currentPos += 0;
		
		}



	}

	public void BlueButton(){
		
		if (boardObj.rowfull != true) {
			boardObj.currentPos+=1;
		//	CurrentCoin = Instantiate (CoinPrefab[2], boardObj.row [boardObj.currentPos].transform.position, Quaternion.identity);
			//CurrentCoin = Instantiate (CoinPrefab[0], boardObj.grid [Board.currentRow,boardObj.currentPos].transform.position, Quaternion.identity);
			CurrentCoin = Instantiate (CoinPrefab[2], boardObj.grid [Board.currentRow,boardObj.currentPos].transform.position, Quaternion.identity);
			//coinSLot.Add (CurrentCoin);
			m_coinSlot [Board.currentRow, boardObj.currentPos] = CurrentCoin;
			Debug.Log(Board.currentRow+ ","+boardObj.currentPos);
			//Debug.Log (coinSLot.Count);

			//Debug.Log (boardObj.currentPos);

		}
		else {

			boardObj.currentPos += 0;

		}

	}

	public void GreenButton(){
		if (boardObj.rowfull != true) {
			boardObj.currentPos+=1;
			//CurrentCoin = Instantiate (CoinPrefab[3], boardObj.row [boardObj.currentPos].transform.position, Quaternion.identity);
			CurrentCoin = Instantiate (CoinPrefab[3], boardObj.grid [Board.currentRow,boardObj.currentPos].transform.position, Quaternion.identity);
		//	coinSLot.Add (CurrentCoin);
			m_coinSlot [Board.currentRow, boardObj.currentPos] = CurrentCoin;
			Debug.Log(Board.currentRow+ ","+boardObj.currentPos);
		//	Debug.Log (coinSLot.Count);

			//Debug.Log (boardObj.currentPos);
		}
		else {

			boardObj.currentPos += 0;

		}



	}

	public void PurpleButton(){
		if (boardObj.rowfull != true) {
			boardObj.currentPos+=1;
		//	CurrentCoin = Instantiate (CoinPrefab[4], boardObj.row [boardObj.currentPos].transform.position, Quaternion.identity);
			CurrentCoin = Instantiate (CoinPrefab[4], boardObj.grid [Board.currentRow,boardObj.currentPos].transform.position, Quaternion.identity);
			//coinSLot.Add (CurrentCoin);
			m_coinSlot [Board.currentRow, boardObj.currentPos] = CurrentCoin;
			//Debug.Log (coinSLot.Count);
			Debug.Log(Board.currentRow+ ","+boardObj.currentPos);

			//Debug.Log (boardObj.currentPos);

		}
		else {

			boardObj.currentPos += 0;

		}

	}


	public void Cancel(){
		if(boardObj.currentPos!=0)
		{
		// Destroy (coinSLot [boardObj.currentPos-1]);

			Destroy (coinSLot [boardObj.currentPos - 1]);
			coinSLot.Remove( coinSLot[boardObj.currentPos-1]);
		//CurrentCoin = CoinPrefab [CoinPrefab.Count - i];
			Debug.Log(coinSLot.Count);
		i++;
		boardObj.currentPos-=1;
	//	CurrentCoin= 
		}
	}

	public void Enter(){
	
		boardObj.Evaluate ();
	
	}


}
