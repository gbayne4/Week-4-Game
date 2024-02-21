using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HomeworkFour
{
    namespace Zombie
    {
        public class ZombieBehavior : MonoBehaviour
        {
            public GameObject player;
            [SerializeField]
            private float height;
            [SerializeField]
            private int speed;
            [SerializeField]
            private int distance;




            Animator zombieanimator;
            // Start is called before the first frame update
            void Start()
            {
                zombieanimator = GetComponent<Animator>();


            }

            //my path finder was giving me trouble so I resorted to this...
            // Update is called once per frame
            void Update()
            {
              
                // have the zombie follow the player once it is close enought
                //zombieanimator.SetBool("close", false);
                if ((Vector3.Distance(player.transform.position, this.transform.position) < distance) && (player.transform.position.y < this.transform.position.y + height))
                {
                    transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.fixedDeltaTime * speed);
                    zombieanimator.SetBool("close", true);

                    transform.LookAt(player.transform.position);
                    transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z);
                }

                /*
                if (lose)
                {
                    loseCountdown++;
                }

                if (loseCountdown > 20)
                {
                    SceneManager.LoadScene(1);
                }
                */
            }
        }
    }
}
