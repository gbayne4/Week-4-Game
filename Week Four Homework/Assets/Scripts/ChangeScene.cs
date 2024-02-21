using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HomeworkFour
{
    namespace SceneTwo
    {
        public class ChangeScene : MonoBehaviour
        {
            public void LoadScene(string sceneName)
            {
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}