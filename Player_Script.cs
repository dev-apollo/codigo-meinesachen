using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Script : MonoBehaviour
{
    public float velocidade;
    public Rigidbody2D corpo;
    private Vector2 direcao;
    public SpriteRenderer sprite;
    public Animator animator;
    public Text itemText;
    private int itemQnt = 0;
    public AudioSource itemSom;

    void Update()
    {
        if(Time.timeScale != 0f){
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");
            direcao = new Vector2(moveX, moveY).normalized;
            if(Mathf.Abs(moveX) > 0.1){
                animator.SetFloat("Speed", Mathf.Abs(moveX));
            }else if(Mathf.Abs(moveY) > 0.1){
                animator.SetFloat("Speed", Mathf.Abs(moveY));
            }else{
                animator.SetFloat("Speed", 0);
            }
            if(moveX < 0){
                sprite.flipX = true;
            }else if(moveX > 0){
                sprite.flipX = false;
            }
            animator.SetFloat("Vertical", moveY);
        }
    }

    void FixedUpdate()
    {
        corpo.velocity = direcao*velocidade*Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.CompareTag("Item") && collison.gameObject.activeSelf){
            collison.gameObject.SetActive(false);
            itemSom.Play();
            itemQnt+=1;
            itemText.text = itemQnt+"/10";
        }
    }
}