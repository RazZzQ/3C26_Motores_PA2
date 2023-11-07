using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int player_lives = 4;
    public int player_points = 0;
    public AudioSource SFX;
    public AudioClip Comer;
    public AudioClip Dolor;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Candy")
        {
            CandyGenerator.instance.ManageCandy(other.gameObject.GetComponent<CandyController>(), this);
            SFX.PlayOneShot(Comer);
        }
        if (other.tag == "Enemy")
        {
            EnemyGenerator.instance.ManageEnemy(other.gameObject.GetComponent<EnemyController>(), this);
            SFX.PlayOneShot(Dolor);
        }
    }
}
