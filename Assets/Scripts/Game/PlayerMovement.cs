using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int player_lives = 4;
    public int player_points = 0;
    public int puntosactuales;
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Candy")
        {
            CandyGenerator.instance.ManageCandy(other.gameObject.GetComponent<CandyController>(), this);
        }
        if (other.tag == "Enemy")
        {
            EnemyGenerator.instance.ManageEnemy(other.gameObject.GetComponent<EnemyController>(), this);
            if (player_lives == 0)
            {
                puntosactuales = PlayerPrefs.GetInt("player_points");
            }
        }
    }
}
