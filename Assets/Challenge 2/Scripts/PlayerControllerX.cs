using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireRate = 2.0f;
    private float nextFire = 0.0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        //Telt de verstreken tijd van het spel en doet daar telkens bij het gebruiken firerate bij in de float Nextfire. 
        //Dit zorgt ervoor dat er telkens 2 seconde wachttijd is.
        if (Input.GetKeyDown(KeyCode.Space) &&  Time.time > nextFire )
        {
            nextFire = Time.time + fireRate;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
