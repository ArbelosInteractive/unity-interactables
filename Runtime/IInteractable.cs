using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Arbelos
{
    public interface IInteractable 
    {
        public AnimatorOverrideController AnimationOverrideController { get; set; }
        public UnityEvent OnInteractEnterEvent { get; set; }
        public UnityEvent OnInteractExitEvent { get; set; }
        public UnityEvent OnInteractUpdateEvent { get; set; }
        public bool ShouldUpdate { get; set; }

        public void OnInteractEnter();
        public void OnInteractExit();
        public void OnInteractUpdate();
    }
}
