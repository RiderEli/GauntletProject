using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : MonoBehaviour
{
    [SerializeField]
    private GameObject elf;
    [SerializeField]
    private GameObject warrior;
    [SerializeField]
    private GameObject valkrie;
    [SerializeField]
    private GameObject wizard;

    private bool isElf = false;
    private bool isWarrior = false;
    private bool isValkier = false;
    private bool isWizard = false;

    private Transform richestPlayer;
    private Rigidbody rb;
    private float speed = 120;
    private float rotSpeed = 3f;
    private float range = 10;
    //private GameObject stolenItem;
    //private GameObject hiToRegPotion;
    private int damage = 10;
    private int treasureBag = 500;
    private bool followPlayer = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    /*
    private void Update()
    {
        //IdentifyRichestPlayer();

        if (followPlayer)
        {
            FollowPlayer();
        }

        if (isAlive)
        {
            escaped = true;
        }
        else
        {
            escaped = false;
        }
    }
    */
    /*
    private void IdentifyRichestPlayer()
    {
        // this is tempoary at the time I am writing this the inventory system for
        // the players has not yet been made - Jerrod Luster
        elf.GetComponent<Elf>().inventory;
        warrior.GetComponent<Warrior>().inventory;
        valkrie.GetComponent<Valkrie>().inventory;
        wizard.GetComponent<Wizard>().inventory;

        // for loop that transverse each inventory to see which player has the most items

        if (Elf >  Warrior && Elf > Valkrie && Elf > Wizard)
        {
            richestPlayer = Elf.trasnform;
        }
        else if (Warrior > Elf && Warrior > Valkrie && Warrior > Wizard)
        {
            richestPlayer = Warrior.transform;
        }
        else if (Valkrie > Elf &&  Valkrie > Warrior &&  Valkrie > && Wizard)
        {
            richestPlayer = Valkrie.transform;
        }
        else if (Wizard > Elf && Wizard > Warrior && Wizard > Valkrie)
        {
            richestPlayer = Wizard.transform;
        }

        followPlayer = true;
    }
    */

    private void FollowPlayer()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(richestPlayer.position - transform.position)
                             , rotSpeed * Time.deltaTime);

        rb.AddForce(speed * Time.deltaTime * transform.forward);
    }

    private void TakeItem()
    {
        if (isElf)
        {
            //elf.GetComponent<Elf>().inventory;
        }
        else if (isWarrior)
        {
            //warrior.GetComponent<Warrior>().inventory;
        }
        else if (isValkier)
        {
            //valkrie.GetComponent<Valkrie>().inventory;
        }
        else if (isWizard)
        {
            //wizard.GetComponent<Wizard>().inventory;
        }

        // for loop to find each item the Thief will steal in order
        // upgraded potion, potions, keys, score, or multiplayer bonus multiplier
    }
    /*
    private void DropItem()
    {
        if (stolenItem == null && isAlive == false)
        {
            // spawn treasureBag = 500
        }
        else
        {
            if (stolen == upPotion && escaped == true)
            {
                // turn upPotion to potion
            }
            else
            {
                // spawn item in next level
            }
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TakeItem();
        }

        if (collision.gameObject.tag == "Weapon")
        {
            isAlive = false;
            DropItem();
        }
    }
    */
}
