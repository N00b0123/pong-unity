using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public float Speed = 5f;
    public GameObject left;
    public GameObject rigth;
    public Vector3 initialPosition =  new Vector3(0,0,0);
    public float SpeedX;
    public float SpeedY;
    public int ScoreLeft = 0;
    public int ScoreRigth = 0;
    public Text RigthScore, LeftScore;
   
    // Start is called before the first frame update
    void Start()
    {
        RigthScore.text = ScoreRigth.ToString();
        LeftScore.text = ScoreLeft.ToString();

        float SpeedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float SpeedY = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(Speed * SpeedX, Speed * SpeedY, 0);
    }

    void OnTriggerEnter(Collider colision)
    {
        if(colision.gameObject.tag == "ScoreR")
        {
            ScoreLeft++;
            LeftScore.text = ScoreLeft.ToString();
            Reset();
        }
        if (colision.gameObject.tag == "ScoreL")
        {
            ScoreRigth++;
            RigthScore.text = ScoreRigth.ToString();
            Reset();
        }
    }

    void Reset()
        {
            gameObject.transform.position = initialPosition;
            SpeedX *= -1;
            SpeedY = Random.Range(0, 2) == 0 ? -1 : 1;
            GetComponent<Rigidbody>().velocity = new Vector3(Speed * SpeedX, Speed * SpeedY, 0);
        }
}