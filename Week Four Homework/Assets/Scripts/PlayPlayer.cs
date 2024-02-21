using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HomeworkFour
{
    public class PlayPlayer : MonoBehaviour
    {
        Rigidbody rb;
        Animator playeranimator;
        [SerializeField]
        private int speed;
        public float drag;

        // Start is called before the first frame update
        void Start()
        {
            rb = gameObject.GetComponent<Rigidbody>();
            rb.drag = drag;

            playeranimator = GetComponent<Animator>();
        }


        // Update is called once per frame
        void Update()
        {
           
            playeranimator.SetBool("moving", false);
            if (Input.GetKey(KeyCode.W))//going forward
            {
                    rb.AddForce(transform.forward * speed);
                    playeranimator.SetBool("moving", true);

            }


             if (Input.GetKey(KeyCode.S)) //going backwards
            {
                rb.AddForce(-transform.forward * speed);
                playeranimator.SetBool("moving", true);
            }

             if (Input.GetKey(KeyCode.A))
            {

                rb.AddForce(-transform.right * speed);
                playeranimator.SetBool("moving", true);

            }


             if (Input.GetKey(KeyCode.D)) //going right
            {
                 rb.AddForce(transform.right * speed);
                 playeranimator.SetBool("moving", true);


            }

                
           
        }

    }
 }
