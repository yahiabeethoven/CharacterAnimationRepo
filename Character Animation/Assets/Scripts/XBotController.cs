using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class XBotController : MonoBehaviour
{
    Animator animator;
	NavMeshAgent agent;
	
	int isWalkingHash;
	
	private void Awake() {
		animator = GetComponent<Animator>();
		agent = GetComponent<NavMeshAgent>();
		
		isWalkingHash = Animator.StringToHash("isWalking");
	}
	
	private void Update() {
		bool isMoving = agent.velocity.magnitude > 0.01f && agent.remainingDistance > agent.radius;
	
		animator.SetBool(isWalkingHash, isMoving);
//		transform.position += transform.forward * Time.deltaTime;
	}
}
