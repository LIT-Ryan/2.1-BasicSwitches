using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbScript : MonoBehaviour
{
    private Animator BulbAnimator;
    private bool BulbBool;

    // Start is called before the first frame update
    void Start()
    {
        BulbAnimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        BulbOn();
        BulbOff();
    }

    void BulbOn()
    {

    }

    void BulbOff()
    {

    }

}
