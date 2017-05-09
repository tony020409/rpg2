using UnityEngine;
using System.Collections;

public class PlayerAnimation : MonoBehaviour {

    private PlayerMove move;

	// Use this for initialization
	void Start () {
        move = this.GetComponent<PlayerMove>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (move.state == PlayerState.Moving) {
            PlayAnim("Run");
        } else if (move.state == PlayerState.Idle) {
            PlayAnim("Idle");
        }
	}

    void PlayAnim(string animName) {
        animation.CrossFade(animName);
    }
}
