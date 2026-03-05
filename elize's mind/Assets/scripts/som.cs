using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio; //Importamos a funcionalidade de audio para conseguir mexer em audio

public class som : MonoBehaviour
{
    [SerializeField] private AudioMixer myAudiomixer; //Variavel tipo audiomixer onde o audio é armazenado

    public void SetVolume(float slidervalue) //Definimos uma função publica(onde o valor pode ser chamadpo dentro da gameplay) onde o valor do slider de audio(0.001 a 1)
                                             //é passado como algo float(decimal)
    {
        myAudiomixer.SetFloat("MasterVolume", Mathf.Log10(slidervalue) * 20); //Decibeis não funcionam igual numeros, (80db / 2 não é 40db) então para convertermos para escala
                                                                              //decibel precisamos usar a escala logaritima(usando essa formula q achei na net), onde especifico
                                                                              //que tipo de som vou alterar(nesse caso altero o Volume Chefe, que afeta todos os outros volumes)
                                                                              //e passo o valor disso para o audiomixer, depois passamos esse valor para o AudioMixer
                                                                              //(que vinculamos) e o som da classe MasterValue vira o valor da função.
    }
}
