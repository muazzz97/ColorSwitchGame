using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballHandler : MonoBehaviour
{
    private Rigidbody2D rb;
    public SpriteRenderer sr;
    public float force;
    public Color SkyBlue, Yellow, Pink, Purple;
     int index;
     string playercolor;
    public GameObject GameoverPnael;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        ChooseRandomColor();
    }


    void ChooseRandomColor()
    {
        index = Random.Range(0, 4);
        switch(index)
        {
            case 0:
                sr.color = SkyBlue;
                playercolor = "Blue";
                break;
            case 1:
                sr.color = Yellow;
                playercolor = "Yellow";
                break;
            case 2:
                sr.color = Pink;
                playercolor = "Pink";
                break;
            case 3:
                sr.color = Purple;
                playercolor = "Purple";
                break;
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (playercolor !=  collision.tag )
        {
           // Debug.Log("Game Over");
            GameoverPnael.SetActive(true);



        }
       
    }

    // Update is called once per frame
    void Update()
    {
     if( Input.GetKeyDown(KeyCode.Space))
     {
            rb.velocity = new Vector2(0, 1 * force);     

     }
    }
}
