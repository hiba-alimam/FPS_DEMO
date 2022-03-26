using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject black_pistol;
    public bool is_fire = false;
    public GameObject muzzle_flash;
    public AudioSource PistolShot;
    public float to_target;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(is_fire == false)
            {
                StartCoroutine(FireThePistol());
            }
        }
    }

    IEnumerator FireThePistol()
    {
        is_fire = true;
        to_target = PlayerCasting.distance_from_target;
        black_pistol.GetComponent<Animator>().Play("fire_pistol");
        PistolShot.Play();
        muzzle_flash.SetActive(true);
        yield return new WaitForSeconds(0.03f);
        muzzle_flash.SetActive(false);
        yield return new WaitForSeconds(0.22f);
        black_pistol.GetComponent<Animator>().Play("default");
        is_fire = false;
    }
}
