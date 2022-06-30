using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Arbelos
{
    public interface IInteractable 
    {
        AnimatorOverrideController animationOverrideController { get; set; };
        UnityEvent OnInteractEnterEvent { get; set; };
        UnityEvent OnInteractExitEvent { get; set; };
        UnityEvent OnInteractUpdateEvent { get; set; };


        protected void OnInteractEnter() 
        { 
            if(OnInteractEnterEvent != null)
            {
                OnInteractEnterEvent.Invoke();
            }
        }
        protected void OnInteractExit() 
        {
            if (OnInteractExitEvent != null)
            {
                OnInteractExitEvent.Invoke();
            }
        }
        protected void OnInteractUpdate() 
        {
            if (OnInteractUpdateEvent != null)
            {
                OnInteractUpdateEvent.Invoke();
            }
        }
    }
}
