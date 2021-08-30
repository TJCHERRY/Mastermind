using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Board : MonoBehaviour {
	int i,j;
	public Text _chances;
	public static int _row=10, _column=5;
	public static int currentRow = 0;
	public int colourMatch = 0;
	public GameObject youWon;
	public GameObject youLost;
	public GameObject cover;
	//public List<GameObject> row; 
	public GameObject whitePinPrefab;
	public GameObject redPinPrefab;
	public GameObject currentPin;
	public int chances=10;
	bool loopbreak=false;
	public GameObject[,] grid= new GameObject[_row,_column];
	public GameObject[,] eval = new GameObject[_row, _column];
	private List<GameObject>colorCodetemp;
	public GameObject[] evaluator = new GameObject[5];
	public bool rowfull = false;
	private PlayerController playaObj;
	private ColourCode codeObj;
	//private bool colourMatch = false;

	public  int currentPos=-1;
	//private Material m_Material;
	// Use this for initialization


	void Start(){
		youWon.SetActive (false);
		youLost.SetActive (false);
		//colorCodetemp = codeObj.colourCode;
		playaObj= gameObject.GetComponent<PlayerController>();
		codeObj = gameObject.GetComponent<ColourCode> ();
		//Debug.Log(colorCodetemp.Count);
		for (int i = 0; i <= _row-1; i++) {
		
			for (int j = 0; j <= _column - 1; j++) {
			
			
				grid [i, j] = GameObject.Find (i + "," + j);
				eval [i, j] = GameObject.Find ("eval_" + i + "," + j);
				Debug.Log (eval.Length);
			
			}
		
		
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (chances >=1) {

			if (colourMatch >= 5) {
				youWon.SetActive (true);
				Destroy (youWon, 3f);
				cover.SetActive (false);
				//_chances.GetComponent<Text> ().text = "YOU WON";
		
			} 


		}
		if(chances<=0)	{
			chances = 0;
			youLost.SetActive (true);
			//Destroy (youLost, 3f);
		}


		_chances.GetComponent<Text>().text = "Chances: "+ chances;
		
		if (currentPos >_column-1) {


			rowfull = true;
			colourMatch = 0;
			foreach (GameObject o in codeObj.colourCode) {

				o.GetComponent<Selection> ().isSelected = false;
			}
			currentRow += 1 ;
			currentPos = -1;
			chances -= 1;

			//playaObj.CurrentCoin = null;
		} 
		else {
		
			rowfull =false;
		}
	}


	public void Evaluate(){
	
		Debug.Log(currentRow+",,,,,,,,"+currentPos);
		for ( i = 0; i <= 4; i++) {
			//Debug.Log(playaObj.m_coinSlot[currentRow,i]);
			for ( j = 0; j <= codeObj.colourCode.Count - 1; j++) {
				
				if (playaObj.m_coinSlot[currentRow,i].GetComponent<Renderer>().material.color == codeObj.colourCode [j].GetComponent<Renderer> ().material.color) {
					/*if (i != j) {
					 
						evaluator[i] = playaObj.coinSLot [i];
						Debug.Log (i+ ","+ j);
					//	Debug.Log ("white pin"+ "  " + playaObj.coinSLot[i].name+ "  " + codeObj.colourCode[j].name);
						//Debug.Log ("red pin" + "  "+ playaObj.coinSLot[i].name+ "  " + codeObj.colourCode[j].name);

						//Debug.Log ("white pin"+ "  " + evaluator[i]);

				} */


					if (i == j) {
						//evaluator [i] = playaObj.coinSLot [i];

						codeObj.colourCode [j].GetComponent<Selection> ().isSelected = true;

						if (codeObj.colourCode [j].GetComponent<Selection> ().isSelected == true) {
							
							currentPin = Instantiate (redPinPrefab, eval [currentRow, i].transform.position, Quaternion.identity);
							//Debug.Log ("red pin" + "  " + playaObj.m_coinSlot[currentRow,i].name);
							//Debug.Log (i + "," + j);
							colourMatch+=1;

							break;
						
						}


					} 
					else {
						
						if (codeObj.colourCode [j].GetComponent<Selection> ().isSelected != true) {
							currentPin = Instantiate (whitePinPrefab, eval [currentRow, i].transform.position, Quaternion.identity);
							//Debug.Log ("white pin" + "  " + playaObj.m_coinSlot[currentRow,i].name);
							codeObj.colourCode [j].GetComponent<Selection> ().isSelected = true;
							//Debug.Log (i + "," + j);
							break;

						}
						//codeObj.colourCode [j].GetComponent<Selection> ().isSelected = true;

					}

				}


				}
			}
		}




}
	


