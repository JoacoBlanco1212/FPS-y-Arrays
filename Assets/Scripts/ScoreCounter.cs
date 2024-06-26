﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCounter : MonoBehaviour
{
    public Text txtScore;
    public int score;
    public int maxScore;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (score < maxScore)
        {
                Debug.Log("Contacto");
                AlimentoScript alimento;
                alimento = collision.gameObject.GetComponent<AlimentoScript>();
                score += alimento.valorAlimentario;
                txtScore.text = score.ToString();
        } 
        else
        {
                txtScore.text = "GANASTE";
        } 
    }
}
