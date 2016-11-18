using UnityEngine;
using System.Collections;

public class TestManager : MonoBehaviour {
    public Actor[] actors;

	void Start () {
        actors = GameObject.Find("ActorGroup").GetComponentsInChildren<Actor>();
	}

    public void PlayAnimation(string str)
    {
        foreach (Actor actor in actors) actor.PlayAnimation(str);
    }

    public void ResetPosition()
    {
        foreach (Actor actor in actors) actor.ResetPosition();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) PlayAnimation("walk");
        if (Input.GetKeyDown(KeyCode.W)) PlayAnimation("run");
        if (Input.GetKeyDown(KeyCode.E)) PlayAnimation("kick1");
        if (Input.GetKeyDown(KeyCode.R)) PlayAnimation("kick2");
        if (Input.GetKeyDown(KeyCode.F)) PlayAnimation("kick3");
        if (Input.GetKeyDown(KeyCode.C)) ResetPosition();
    }
}
