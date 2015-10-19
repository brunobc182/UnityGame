using UnityEngine;
using System.Collections;

public class Menu2 : MonoBehaviour {
	bool estaVisivel = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.P) && (estaVisivel == false)){
			estaVisivel = true;
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			estaVisivel = false;	
		}
	}
	
	//Desenhar interfarce grafica
	void OnGUI(){
		if (estaVisivel) {
			if (GUI.Button (new Rect (10, 10, 150, 50), "Novo")) {
				print ("Voce pressionou o botao Novo");
				Application.LoadLevel (1);
				estaVisivel = false;
			}
			else if (GUI.Button (new Rect (10, 65, 150, 50), "Proximo Nivel")) {
				print ("Voce pressionou o botao Proximo Nivel");
				Application.LoadLevel (2);
				estaVisivel = false;
			}
			
		}
	}
}
