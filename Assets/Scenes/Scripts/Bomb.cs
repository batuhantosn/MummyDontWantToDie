using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bomb : MonoBehaviour
{
    [SerializeField] private GameObject bomb;
    [SerializeField] private Animator bombAnim;
    [SerializeField] private int bombTimer = 3;
    private bool damageBool = false;
   
    void Start()
    {
        StartCoroutine(ExecuteAfterTime(bombTimer));
        bombAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ExecuteAfterTime(float waittime)
    {
        yield return new WaitForSeconds(waittime);
        bombAnim.SetBool("atack", true);
        if (damageBool == true)
        {
            
            if (PlayerScript.health == 0)
            {
                SceneManager.LoadScene(0);
            }
            else PlayerScript.health = PlayerScript.health - 20;
            Debug.Log(PlayerScript.health);
        }
        Destroy(bomb);
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            damageBool = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
       if (other.gameObject.tag == "Player")
        {
            damageBool = false;
        }  
    } 

}
