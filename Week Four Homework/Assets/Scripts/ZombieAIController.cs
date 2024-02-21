using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace HomeworkFour
{
    public class ZombieAIController : MonoBehaviour
    {
        public GameObject player;
        private NavMeshAgent zombie;
        // Start is called before the first frame update
        void Start()
        { 
            //zombie should find the player based on the position.
            zombie = GetComponent<NavMeshAgent>();

            zombie.SetDestination(player.transform.position);
        }
//was struggling a bit at first since my first attempt with path nav failed so I got some help from this video: https://www.youtube.com/watch?v=K6bBC0qkImI
        
        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
