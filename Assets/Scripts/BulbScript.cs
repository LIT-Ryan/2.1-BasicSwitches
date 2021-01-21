using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbScript : MonoBehaviour
{
   public Animator BulbAnimator;
    private bool BulbTrigger;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BulbOn()
    {
        BulbAnimator.SetBool("BulbTrigger" , true);
        Debug.Log("test");
    }

    public void BulbOff()
    {
        BulbAnimator.SetBool("BulbTrigger", false);
    }

}