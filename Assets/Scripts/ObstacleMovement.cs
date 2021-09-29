using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] float yPush = 4f;
    Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        Debug.Log(screenBounds);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if(transform.position.y >= screenBounds.y * 1.5)
        {
            Destroy(this.gameObject);
        }
    }

    public void Move()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, yPush);
    }
}
