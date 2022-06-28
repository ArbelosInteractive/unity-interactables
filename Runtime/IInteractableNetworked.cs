using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stemuli
{
    public class IInteractableNetworked : MonoBehaviour
    {
        private AnimationOverrideController animationOverrideController;
        public virtual AnimationOverrideController rpc_overrideController;
        public virtual rpc_interact()
        {
            Debug.Log("Interacting over the network....");
        }

    }
}
