using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    public class Disable : MonoBehaviourPun
    {
        private PhotonView view;
        private ThirdPersonUserControl user;
        private ThirdPersonCharacter character;
        // Start is called before the first frame update
        void Start()
        {
            view = GetComponent<PhotonView>();
            user = GetComponent<ThirdPersonUserControl>();
            character = GetComponent<ThirdPersonCharacter>();

            if (view.IsMine)
            {
                gameObject.tag = "Player";
            }

            else
            {
                Destroy(user);
                Destroy(character);
                Destroy(this);
            }

        }

    }
}

