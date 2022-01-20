using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Playermovement : MonoBehaviour
{
    public float speed;
    Rigidbody PlayerRb;

    //coin text/score
    public Text cointxt;
    int coin;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
        cointxt.text = "Coin Collected: " + coin;
    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveH, 0, moveV);
        PlayerRb.AddForce(movement * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hazards")
        {
            SceneManager.LoadScene("GameLose");
        }

        if (collision.gameObject.tag == "Coin")
        {
            coin++;
            cointxt.text = "Coin Collected: " + coin;
            Destroy(collision.gameObject);

            if(coin == 4)
            {
                SceneManager.LoadScene("GameWin");
            }
        }

    }
}
