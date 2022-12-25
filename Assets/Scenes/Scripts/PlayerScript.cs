using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private int speed, sensivity;
    public FixedJoystick variableJoystick;
    public Text scoreText;
    public Text healthText;
    Animator _anim;
    static public int score = 0;
    public static int health = 100;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        _anim = GetComponent<Animator>();
        ControllPlayer();
        healthText.text = "HEALTH : " + health;
    }
    void ControllPlayer()
    {
        

        Vector3 movement = Vector3.forward * variableJoystick.Vertical + Vector3.right * variableJoystick.Horizontal;

        if (movement != Vector3.zero)
        {
            _anim.SetBool("walk",true);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement.normalized), 0.2f);
        }
        else _anim.SetBool("walk", false);


        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        
    }
    private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.tag == "tp")
        {
            score += 100;
            scoreText.text = "SCORE : "+ score;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "tpx2")
        {
            score += 200;
            scoreText.text = "SCORE : " + score;
            Destroy(collision.gameObject);
        }

    }
}