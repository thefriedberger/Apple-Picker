using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {
    //Prefab for instantiating apples
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 20f;
    public float chanceToChangeDirection = 0.1f;
    public float secondsBetweenDrops = 1f;

	// Use this for initialization
	void Start () {
        //dropping apples every second
        InvokeRepeating("DropApple", 2f, secondsBetweenDrops);

        int level = DifficultySelect.difficulty;

        if (level == 1) {
            speed = 5f;
            secondsBetweenDrops = 1f;
        } else if (level == 2) {
            speed = 15f;
            secondsBetweenDrops = 0.3f;
        } else if (level == 3) {
            speed = 45f;
            secondsBetweenDrops = 0.05f;
            chanceToChangeDirection = 0.05f;
        }
    }

    void DropApple () {
        GameObject apple = Instantiate(applePrefab) as GameObject;
        apple.transform.position = transform.position;
    }
	
	// Update is called once per frame
	void Update () {        
        //basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //changing direction
        if (pos.x < -leftAndRightEdge) {
            speed = Mathf.Abs(speed);
        } else if (pos.x > leftAndRightEdge) {
            speed = -Mathf.Abs(speed);
        } 
    }
    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirection) {
            speed *= -1;
        }
    }
}
