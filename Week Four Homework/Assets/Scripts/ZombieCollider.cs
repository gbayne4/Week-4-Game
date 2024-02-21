using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HomeworkFour
{
    namespace Zombie
    {
        public class ZombieCollider : MonoBehaviour
        {
            // Start is called before the first frame update
            void Start()
            {

            }
            private void OnCollisionEnter(Collision collision)
            {

                //if you hit an obstacle
                if (collision.gameObject.tag == "Player") //if we collide with a game object whose tag is equal to ground
                {
                    //zombieanimator.SetBool("attack", true);
                    YouWinLose.survived = false;
                    // lose = true;
                    SceneManager.LoadScene(1);
                }

            }

            // Update is called once per frame
            void Update()
            {

            }
        }
    }
}
