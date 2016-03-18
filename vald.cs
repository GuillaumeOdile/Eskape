using UnityEngine;
using System.Collections;

public class vald : MonoBehaviour
{
    bool arme = false;
    bool is_walking = false;
    bool dead = false;
    Animator anim;
  //  int jumpHash = Animator.StringToHash("idle");
  //  int runStateHash = Animator.StringToHash("Base Layer.Walk");
   
    void estmort(bool test)
    {
        dead = test;
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        

        if ((Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")) && !arme && !dead)
        {
            anim.SetFloat("is_walking", 1F);
            anim.SetFloat("arme", 0F);
            anim.Play("walking");
            is_walking = true;
        }

        if ((!Input.GetKey("d") && !Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("w")) && !arme && !dead)
        {
            anim.SetFloat("is_walking", 0.0F);
            anim.SetFloat("arme", 0F);
            anim.Play("idle");
        }

        if (Input.GetKeyDown("e")) arme = !arme;
        if (arme) anim.SetFloat("arme", 1F);

        if ((Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")) && arme && !dead)
        {
            anim.SetFloat("is_walking", 1F);
            anim.SetFloat("arme", 1F);
            anim.Play("walking_aiming");
            is_walking = true;
        }

        if ((!Input.GetKey("d") && !Input.GetKey("a") && !Input.GetKey("s") && !Input.GetKey("w")) && arme && !dead)
        {
            anim.SetFloat("is_walking", 0.0F);
            anim.SetFloat("arme", 1F);
            anim.Play("idle_aiming");
        }

        Debug.Log("walk: " + is_walking);

    }
}