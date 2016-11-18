using UnityEngine;
using System.Collections;

public class Actor : MonoBehaviour {
    Animator animator;
    Transform tf;
    SpriteRenderer sr;
    Vector3 savedPosition;

	void Start () {
        animator = GetComponent<Animator>();
        tf = transform;
        sr = GetComponent<SpriteRenderer>();
        savedPosition = tf.position;
	}

    public void ResetPosition()
    {
        tf.position = savedPosition;
    }

    public void PlayAnimation(string str)
    {
        animator.Play(str);
    }

    public void SyncPosition()
    {
        Vector3 pos = tf.position;
        float dist = 1.4f;
        dist = sr.sprite.bounds.center.x;
        pos += Vector3.right * dist;
        tf.position = pos;
    }

    public void SyncPosition_Kick1()
    {
        SyncPosition();
    }

    public void SyncPosition_Kick2()
    {
        SyncPosition();
    }

    public void SyncPosition_Kick3()
    {
        SyncPosition();
    }
}
