﻿using UnityEngine;

namespace Assets.Scripts
{
    public class BaseFrameController : MonoBehaviour {

        public GameObject panel;

        SpriteRenderer sr;

        protected bool repeatFire = false;


        protected void Init () {
            sr = GetComponent<SpriteRenderer>();
        }

        virtual public void TurnOff()
        {
            sr.enabled = false;
            panel.SetActive(false);
            repeatFire = false;
        }

        public void TurnOn()
        {
            sr.enabled = true;
            panel.SetActive(true);
        }
    }

}

