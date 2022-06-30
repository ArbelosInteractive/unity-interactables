using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Arbelos
{
    public interface IInteractable 
    {
        AnimatorOverrideController animationOverrideController { get; set; }
        UnityEvent OnInteractEnterEvent { get; set; }
        UnityEvent OnInteractExitEvent { get; set; }
        UnityEvent OnInteractUpdateEvent { get; set; }


        public void OnInteractEnter() {  }
        public void OnInteractExit() { }
        public void OnInteractUpdate() { }
    }
}
