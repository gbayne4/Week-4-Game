using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HomeworkFour
{
    public class YouWin : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {

            //if you hit an obstacle
            if (collision.gameObject.tag == "Player") 
            {
                //made it to the finish line 
                YouWinLose.survived = true;
                SceneManager.LoadScene(1);
            }

        }
    }
}
