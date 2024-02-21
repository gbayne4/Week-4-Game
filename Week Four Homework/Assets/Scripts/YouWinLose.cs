using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace HomeworkFour
{
 //I'm getting used to namespaces, so I had to change this one from Scene 2 to Zombie to none to work
  
        public class YouWinLose : MonoBehaviour
        {
            TextMeshProUGUI WinLose;
            public static bool survived;
            // Start is called before the first frame update
            void Start()
            {

                WinLose = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            }

            // Update is called once per frame
            void Update()
            {
                string message = (survived) ? "You lived!" : "You died.";
                WinLose.text = message;

            }
        }

}
