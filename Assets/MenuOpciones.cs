using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void PantallaCompleta(bool pantallcompleta)
    {
        Screen.fullScreen = pantallcompleta;
        
    }

    public void CambiarVolumen(float volumen)
    {
        audioMixer.SetFloat("Volumen",volumen);
    }

    public void CambiarCalidad(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }
}
