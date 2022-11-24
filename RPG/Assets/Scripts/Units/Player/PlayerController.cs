using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Units.Player
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _speedPlayer = 5f;
        private void Update()
        {
            var ad = Input.GetAxis("Horizontal");
            if (ad != 0)
            {
                transform.position += _speedPlayer * ad * Time.deltaTime * Vector3.right;
            }

            var ws = Input.GetAxis("Vertical");
            if (ws != 0)
            {
                transform.position += _speedPlayer * Time.deltaTime * ws * Vector3.forward;
            }
        }
    }

}


