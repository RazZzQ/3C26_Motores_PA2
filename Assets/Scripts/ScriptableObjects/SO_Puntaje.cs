using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_Puntaje", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 0)]
public class SO_Puntaje : ScriptableObject
{
    public int ScoreActual = 0;
    public int maxScore = 0;
    
    // Start is called before the first frame update
    public void Awake()
    {
    }
    public int actualizarScore()
    {
        if(ScoreActual >= maxScore)
        {
            maxScore = ScoreActual;    
        }
        return maxScore;
    }
}
