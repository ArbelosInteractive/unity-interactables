using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stemuli
{
    public class IInteractable : MonoBehaviour
    {
        private AnimationOverrideController animationOverrideController;
        public virtual IInteractable()
        {
            Debug.Log("Interacting....");
        }
    }
}
