using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//adicionar o using para a UI
using UnityEngine.UI;
//adicionar o using para o gerenciador de Cena
using UnityEngine.SceneManagement;

public class Cronometro : MonoBehaviour
{
	public Text CronometroText;
	private float tempoAtual;
    // Start is called before the first frame update
    void Start()
    {
        tempoAtual = 0;
    }

    // Update is called once per frame
    void Update()
    {
		//deltaTime --> Tempo de renderização entre dois frames
		tempoAtual += Time.deltaTime;
		//formata o tempoAtual(float) para texto utilizando duas casas decimais (F2)
		CronometroText.text = tempoAtual.ToString("F2");   
		if (tempoAtual>5.0)
		{
			SceneManager.LoadScene ("Menu");
		}
    }
}
