﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CandyGenerator : MonoBehaviour
{
    public static CandyGenerator instance;
    public SO_Puntaje score;
    public List<GameObject> Candies = new List<GameObject>();
    private float time_to_create = 4f;
    private float actual_time = 0f;
    private float limitSuperior;
    private float limitInferior;
    public List<GameObject> actual_candies = new List<GameObject>();

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        SetMinMax();
    }

    // Update is called once per frame
    void Update()
    {
        actual_time += Time.deltaTime;
        if (time_to_create <= actual_time)
        {
            GameObject candy = Instantiate(Candies[Random.Range(0, Candies.Count)],
            new Vector3(transform.position.x, Random.Range(limitInferior, limitSuperior), 0f), Quaternion.identity);
            candy.GetComponent<Rigidbody2D>().velocity = new Vector2(-2f, 0);
            actual_time = 0f;
            actual_candies.Add(candy);
        }
    }

    void SetMinMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        limitInferior = -(bounds.y * 0.9f);
        limitSuperior = (bounds.y * 0.9f);
    }

    public void ManageCandy(CandyController candy_script, PlayerMovement player_script = null)
    {
        if (player_script == null)
        {
            Destroy(candy_script.gameObject);
            return;
        }

        int Points = score.ScoreActual;
        int Points_changer = candy_script.PointsChange;
        Points += Points_changer;
        print(Points);
        score.ScoreActual = Points;
        Destroy(candy_script.gameObject);
    }
}
