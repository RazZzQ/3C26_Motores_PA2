using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_Puntaje", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 0)]
public class SO_Puntaje : ScriptableObject
{
    public static PlayerMovement instance;
    public int ScoreActual = 0;
    public int maxScore = 0;
    // Start is called before the first frame update
    public void Start()
    {
        ScoreActual = instance.puntosactuales;
    }
    public int actualizarScore()
    {
        if(ScoreActual >= maxScore)
        {
            maxScore = ScoreActual;
            return maxScore;
        }
        else
        {
            return ScoreActual;
        }
    }
}
