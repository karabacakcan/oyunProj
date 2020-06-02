using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    string[] atack = { "Attack1", "Attack2", "Attack3" };
    Animator anim;
    float coolDown = .75f;
    int i = -1;
    RangeFinder trig;
    public bool ikActive = false;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        trig = GetComponent<RangeFinder>();
	}

    // Update is called once per frame
    void Update()
    {
        if (ikActive == false)
        {
            Saldiri();
        }
    }
    void Saldiri()
    {
        if (Input.GetKey(KeyCode.Mouse0) && coolDown >= 0)
        {
            if (i > atack.Length)
            {
                i = -1;
            }
            i++;
            coolDown -= Time.deltaTime;
            StartCoroutine(Anim());
            if (trig.Inrange)
            {
                anim.bodyRotation = trig.Pozisyo;
                ikActive = true;
            }
        }
    }
    
    IEnumerator Anim()
    {
        anim.SetTrigger(atack[i]);
        yield return new WaitForSeconds(0.75f);
        coolDown = .7f;
    }
    //private void OnAnimatorIK(int layerIndex)
    //{
    //    if (ikActive)
    //    {
    //        anim.SetLookAtPosition(trig.hedef.position);
    //        if (Input.GetKey(KeyCode.Mouse0))
    //        {
    //            anim.SetFloat("ElUzanma", 1, 0.1f, Time.deltaTime * 0.03f);
    //            //anim.SetIKPositionWeight(AvatarIKGoal.RightHand, anim.GetFloat("ElUzanma"));
    //            anim.SetIKPosition(AvatarIKGoal.LeftHand, trig.hedef.position);
    //            anim.SetLookAtWeight(anim.GetFloat("ElUzanma"));
    //            anim.SetLookAtPosition(trig.hedef.position);
    //            anim.SetTrigger("Attack1");
    //        }
    //        else
    //        {
    //            anim.SetFloat("ElUzanma", 0);
    //        }
    //    }
    //}
}
