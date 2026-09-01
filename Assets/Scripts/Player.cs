using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    void Start()
    {
        // aumentei a velocidade do player  
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, moveY, 0f) * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}
