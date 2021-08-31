using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//adicionar o using para o gerenciador de Cena
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    //remover os métodos default
	public void CarregarFase1(){
		//método inicia uma nova cena
		SceneManager.LoadScene ("Fase1");
	}
	public void Sair()
	{
		Application.Quit();
	}
}
