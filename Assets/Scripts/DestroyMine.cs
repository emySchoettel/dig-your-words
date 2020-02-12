using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android; 
public class DestroyMine : MonoBehaviour
{

    public GameObject uneMine;

    private GameObject lePlayer;

    protected SpriteRenderer unSprite;
    // Start is called before the first frame update
    void Start()
    {
        lePlayer = GameObject.Find("player");
        unSprite = uneMine.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        Animator animator = lePlayer.GetComponent<Animator>();       
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray  = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit; 
            if (Physics.Raycast(ray, out hit))
            {
                Destroy(hit.collider.gameObject);
                animator.Play("Attack");
                lePlayer.GetComponent<AudioSource>().Play(0);
                animator.Play("IDLE");
            }
        }
    }
}
