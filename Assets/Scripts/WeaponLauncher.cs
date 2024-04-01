using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponLauncher : MonoBehaviour
{
    public GameObject weaponPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 0.5f, 0.5f);
    }

    void Fire()
    {
        Instantiate(weaponPrefab, transform.position, Quaternion.identity);
    }
}
