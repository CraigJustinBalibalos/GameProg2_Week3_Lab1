using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider obj){
        if(obj.tag == "Player" ){
            GameManager.Instance.score++;
            Debug.Log("You Scored!!");
            if(GameManager.Instance.score == 5){
                Debug.Log("You Win!!");
                GameManager.Instance.score = 0;
            }
        }
    }
}
